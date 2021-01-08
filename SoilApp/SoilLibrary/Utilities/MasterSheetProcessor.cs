using SoilLibrary.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using SoilLibrary.Factories;
using System;

namespace SoilLibrary.Utilities
{
    public static class MasterSheetProcessor
    {
        private static IList<object> Headers { get; set; }
        private static IList<IList<object>> Rows { get; set; }
        private static IList<IFieldModel> Fields { get; set; } = new List<IFieldModel>() { };
        private static IDictionary<string, int> RelevantColumns { get; set; }

        private static IDictionary<string, int> RotationColumns { get; set; }

        private static readonly int ProductTypeId = GlobalConfig.Connection.
    GetDimensionedQuantityTypeId_ByName("Product");

        private static readonly IList<DimensionedQuantityModel> Crops = GlobalConfig.Connection.
            GetDimensionedQuantity_ByType(ProductTypeId);

        private readonly static Regex FarmNameRegex = new Regex("^Farm");
        private readonly static Regex FieldNameRegex = new Regex("^Field");
        private readonly static Regex RotationRegex = new Regex("\\d{4} SPRING");
        private readonly static Regex IdRegex = new Regex("^id");

        private static IList<IList<object>> IdUpdateList = new List<IList<object>>();



        public static IList<IList<object>> Process(IList<IList<object>> rows)
        {
            // Pop header row off front of list of rows
            Rows = rows;
            Headers = rows[0];
            Rows.RemoveAt(0);
            RelevantColumns = GetRelevantColumns(Headers);
            RotationColumns = GetRotationColumns(RelevantColumns);

            foreach (var row in Rows)
            {
                ProcessRow(row);
            }

            return IdUpdateList;
        }
        private static IDictionary<string, int> GetRelevantColumns(IList<object> headers)
        {
            IDictionary<string, int> indices = new Dictionary<string, int>();
            foreach (string header in headers)
            {
                if (FarmNameRegex.IsMatch(header))
                {
                    indices.Add("Farm", headers.IndexOf(header));
                }
                if (FieldNameRegex.IsMatch(header))
                {
                    indices.Add("Field", headers.IndexOf(header));
                }
                if (IdRegex.IsMatch(header))
                {
                    indices.Add("Id", headers.IndexOf(header));
                }
                if (RotationRegex.IsMatch(header))
                {
                    indices.Add(header, headers.IndexOf(header));
                }
            }
            return indices;
        }
        private static IDictionary<string, int> GetRotationColumns(IDictionary<string, int> allColumns)
        {
            IDictionary<string, int> rotationColumns = new Dictionary<string, int>();

            foreach (var key in allColumns.Keys)
            {
                Regex yearRegex = new Regex("(\\d{4})");
                if (yearRegex.IsMatch(key.ToString()))
                {
                    string rotationYear = yearRegex.Match(key.ToString()).Groups[0].Value;
                    rotationColumns.Add(rotationYear, allColumns[key]);
                }
            }
            return rotationColumns;
        }

        public static void ProcessRow(IList<object> row)
        {
            IFieldModel newField = ModelFactory.CreateFieldModel();

            if (ValidField(row))
            {
                int farmNameIndex = RelevantColumns["Farm"];
                string farmNameValue = (string)row[farmNameIndex];
                int fieldNameIndex = RelevantColumns["Field"];
                string fieldNameValue = (string)row[fieldNameIndex];
                int idIndex = RelevantColumns["Id"];
                int idValue = Convert.ToInt32(row[idIndex]);

                newField.Farm = farmNameValue;
                newField.Field = fieldNameValue;
                newField.Id = idValue > 0 ? idValue : -1;
            } else
            {
                return;
            }

            if (newField.Farm.Length > 0 && newField.Field.Length > 0)
            {
                GlobalConfig.Connection.CreateField(newField);
            } else
            {
                return;
            }

            // If the Id is not greater than or equal to one, we don't make a rotation object
            if (newField.Id >= 1)
            {
                if (RotationColumns.Count > 0)
                {
                    foreach (var rotationColumn in RotationColumns.Keys)
                    {
                        RotationModel rotation = new RotationModel
                        {
                            Year = int.Parse(rotationColumn),
                            FieldId = newField.Id
                        };

                        //Finds this rotation column's index in master sheet in order to retrieve
                        //the crop for this field and season combination
                        int currentRotationIndex = RotationColumns[rotationColumn];

                        string cropName = (string)row[currentRotationIndex];

                        foreach (var product in Crops)
                        {
                            if (product.ItemName.ToLower() == cropName.ToLower())
                            {
                                rotation.ProductId = product.Id;
                                newField.Rotations.Add(rotation);
                            }
                        }
                    }
                    GlobalConfig.Connection.CreateRotation_Batch(newField.Rotations);
                } else
                {
                    return;
                }
                Fields.Add(newField);
                IList<object> updateRow = new List<object>() { newField.Farm, newField.Field, newField.Id };
                updateRow.Add(newField.Farm);
                updateRow.Add(newField.Field);
                updateRow.Add(newField.Id.ToString());
                IdUpdateList.Add(updateRow);
            }
            
        }

        private static bool ValidField(IList<object> row)
        {
            bool output = true;

            if (FieldColumnsExist())
            {
                Regex farmNameChecker = new Regex("[HSJ][OCRZ]-\\w*");
                int farmNameIndex = RelevantColumns["Farm"];
                string farmNameValue = (string)row[farmNameIndex];

                Regex fieldNameChecker = new Regex("[CP][0,1,2,3]\\d");
                int fieldNameIndex = RelevantColumns["Field"];
                string fieldNameValue = (string)row[fieldNameIndex];
                // Validate farm name and field name
                if (!farmNameChecker.IsMatch(farmNameValue) && !fieldNameChecker.IsMatch(fieldNameValue))
                {
                    output = false;
                }
                if (farmNameValue.Length <= 0 && fieldNameValue.Length <= 0)
                {
                    output = false;
                }
            }
            return output;
        }

        private static bool FieldColumnsExist()
        {
            bool output = true;

            bool farmNameColumnExists = RelevantColumns.TryGetValue("Farm", out int farmIndex);
            bool fieldNameColumnExists = RelevantColumns.TryGetValue("Field", out int fieldIndex);
            bool idColumnExists = RelevantColumns.TryGetValue("Id", out int idIndex);

            if (farmNameColumnExists == false)
            {
                output = false;
            }            
            if (fieldNameColumnExists == false)
            {
                output = false;
            }
            if (idColumnExists == false)
            {
                output = false;
            }

            return output;
        }
    }
}
