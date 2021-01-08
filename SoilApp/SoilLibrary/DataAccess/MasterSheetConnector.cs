using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoilLibrary.Utilities;
using SoilLibrary.Models;
using System.Text.RegularExpressions;

namespace SoilLibrary.DataAccess
{
    public class MasterSheetConnector
    {
        private static readonly string SpreadsheetId = "1AUMOHvJnfGT5Ve1Ep-ECslC9bhj8sP0DAI64CmQ-iWw";

        private readonly GoogleSheetsConnector SheetsConnection = new GoogleSheetsConnector(SpreadsheetId);
        
        private static readonly string SheetRange = "'Master Sheet'";

        public List<FieldModel> Fields = new List<FieldModel>();
        private static readonly int ProductTypeId = GlobalConfig.Connection.
            GetDimensionedQuantityTypeId_ByName("Product");
        private static readonly List<DimensionedQuantityModel> Crops = GlobalConfig.Connection.
            GetDimensionedQuantity_ByType(ProductTypeId);

        public IList<IList<object>> GetSheetValues()
        {
            return SheetsConnection.GetSheetValues(SheetRange);
        }
        
        public void UpsertFieldsAndRotations()
        {
            //TODO - Clean up this code

            MasterSheetConnector ms = new MasterSheetConnector();

            var rows = ms.GetSheetValues();

            // Pop header row off front of list of rows
            var headers = rows[0];
            rows.RemoveAt(0);

            List<IList<object>> idUpdateList = new List<IList<object>>();
            Dictionary<string, int> relevantColumns = MasterSheetProcessor.GetRelevantColumns(headers);
            Dictionary<string, int> rotationColumns = MasterSheetProcessor.GetRotationColumns(relevantColumns);

            foreach (var row in rows)
            {
                FieldModel newField = new FieldModel();
                bool farmNameColumnExists = relevantColumns.TryGetValue("Farm", out int farmIndex);

                if (farmNameColumnExists)
                {
                    newField.Farm = (string)row[farmIndex];
                }

                bool fieldNameColumnExists = relevantColumns.TryGetValue("Field", out int fieldIndex);

                if (fieldNameColumnExists)
                {
                    Regex okayFieldName = new Regex("[CP][0,1,2,3]\\d");
                    bool validFieldName = okayFieldName.IsMatch((string)row[fieldIndex]);

                    if (validFieldName == false)
                    {
                        continue;
                    }
                    newField.Field = (string)row[fieldIndex];
                }

                bool idColumnExists = relevantColumns.TryGetValue("Id", out int idIndex);

                if (idColumnExists)
                {
                    int.TryParse((string)row[idIndex], out int rowId);
                    newField.Id = rowId;
                }
                newField = GlobalConfig.Connection.CreateField(newField);

                if (rotationColumns.Count > 0)
                {
                    foreach (var rotationColumn in rotationColumns.Keys)
                    {
                        RotationModel rotation = new RotationModel
                        {
                            Year = int.Parse(rotationColumn),
                            FieldId = newField.Id >= 1 ? newField.Id : 0
                            
                        };

                        //Finds this rotation column's index in master sheet in order to retrieve
                        //the crop for this field and season combination
                        int currentRotationIndex = rotationColumns[rotationColumn];

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
                }
                ms.Fields.Add(newField);
                List<object> updateRow = new List<object>() { newField.Farm, newField.Field, newField.Id};
                updateRow.Add(newField.Farm);
                updateRow.Add(newField.Field);
                updateRow.Add(newField.Id.ToString());
                idUpdateList.Add(updateRow);
            }
            UpdateFieldIds(idUpdateList);
        }

        public void UpdateFieldIds(List<IList<object>> values)
        {
            SheetsConnection.WriteValuesToRange(values, "DatabaseIds!A1");
        }
    }
}
