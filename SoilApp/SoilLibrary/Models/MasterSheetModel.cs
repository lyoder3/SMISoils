using SoilLibrary.Models;
using SoilLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SoilLibrary.Models
{
    public class MasterSheetModel
    {
        public List<FieldModel> Fields { get; set; } = new List<FieldModel>();
        private static Regex FarmNameRegex { get; set; } = new Regex("^Farm");
        private static Regex FieldNameRegex { get; set; } = new Regex("^Field");
        private static Regex RotationRegex { get; set; } = new Regex("\\d{4} SPRING");
        private static Regex IdRegex { get; set; } = new Regex("^id");

        public MasterSheetModel()
        {
            //TODO - Finish parsing out fields and rotations and write to database
            var rows = MasterSheetConnection.GetValues();
            var headers = rows[0];
            Dictionary<string, int> allColumns = GetDesiredColumns(headers);
            Dictionary<string, int> rotationColumns = GetRotationColumns(allColumns);

            foreach (var row in rows)
            {
                FieldModel newField = new FieldModel();
                bool farmNameColumnExists = allColumns.TryGetValue("Farm", out int farmIndex);
                
                if (farmNameColumnExists)
                {
                    newField.Farm = (string)row[farmIndex];
                }

                bool fieldNameColumnExists = allColumns.TryGetValue("Field", out int fieldIndex);

                if (fieldNameColumnExists)
                {
                    Regex okayFieldName = new Regex("[CP][0-3][1-9]");
                    bool invalidFieldName = okayFieldName.IsMatch((string)row[fieldIndex]);
                    
                    if (invalidFieldName)
                    {
                        continue;
                    }
                    newField.Field = (string)row[fieldIndex]; 
                }
                
                bool idColumnExists = allColumns.TryGetValue("Id", out int idIndex);

                if (idColumnExists)
                {
                    newField.Id = (int)row[idIndex];
                }

                if (rotationColumns.Count > 0)
                {
                    foreach (var rotationColumn in rotationColumns.Keys)
                    {
                        RotationModel rotation = new RotationModel();
                        rotation.Year = int.Parse(rotationColumn);

                        //Finds this rotation column's index in master sheet in order to retrieve
                        //the crop for this field and season combination
                        int currentRotationIndex = rotationColumns[rotationColumn];

                        rotation.Crop = (string)row[currentRotationIndex];
                    }
                }


            }
        }

        private static Dictionary<string, int> GetDesiredColumns(IList<object> headers)
        {
            Dictionary<string, int> indices = new Dictionary<string, int>();
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
        private static Dictionary<string, int> GetRotationColumns(Dictionary<string, int> allColumns)
        {
            Dictionary<string, int> rotationColumns = new Dictionary<string, int>();
            
            foreach (var key in allColumns.Keys)
            {
                Regex yearRegex = new Regex("(\\d{4})");
                string rotationYear = yearRegex.Match(key).Groups[0].Value;
                rotationColumns.Add(rotationYear, allColumns[key]);
            }
        }
        public static void PrintValues()
        {
            MasterSheetModel ms = new MasterSheetModel();

            foreach (var field in ms.Fields)
            {
                Console.WriteLine($"{field.Farm}, {field.Field}, {field.Rotations}");
            }
        }
    }
}
