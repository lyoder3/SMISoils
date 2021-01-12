using SoilLibrary.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.Linq;

namespace SoilLibrary.Utilities
{
    public class MasterSheetProcessor : IMasterSheetProcessor
    {
        private MasterSheetColumnProcessor columnProcessor { get; set; }
        private IList<IList<object>> RawRows { get; set; }
        private IList<FieldModel> Fields { get; set; } = new List<FieldModel>() { };
        private IList<ProductModel> Crops { get; set; }
        public IList<IList<object>> IdUpdateList { get; private set; } = new List<IList<object>>();
        public int FieldNameIndex { get; set; }
        public int FarmNameIndex { get; set; }
        public int IdIndex { get; set; }
        private IDictionary<int, int> RotationColumns { get; set; }

        public MasterSheetProcessor(IList<IList<object>> rows)
        {
            RawRows = rows;
            Crops = GlobalConfig.Connection.GetProducts_All();
        }
        public void PopHeaders()
        {
            var headers = RawRows[0];
            RawRows.RemoveAt(0);

            columnProcessor = new MasterSheetColumnProcessor(headers);
        }
        public void ProcessRows()
        {
            PopHeaders();
            columnProcessor.MapColumns();

            FieldNameIndex = columnProcessor.FieldNameIndex;
            FarmNameIndex = columnProcessor.FarmNameIndex;
            IdIndex = columnProcessor.IdIndex;
            RotationColumns = columnProcessor.RotationColumns;

            foreach (var row in RawRows)
            {
                ProcessRow(row);
            }
        }

        public void ProcessRow(IList<object> row)
        {
            FieldModel newField = new FieldModel()
            {
                Field = (string)row[FieldNameIndex],
                Farm = (string)row[FarmNameIndex],
            };
            GlobalConfig.Connection.CreateField(newField);

            foreach (var rotationColumn in RotationColumns)
            {
                int columnIndex = rotationColumn.Value;
                RotationModel newRotation = new RotationModel()
                {
                    FieldId = newField.Id,
                    RotationYear = rotationColumn.Key
                };
                string plannedCrop = (string)row[columnIndex];

                if (plannedCrop.Length > 0)
                {
                    // convert names to lowercase so just the text is being compared
                    IList<ProductModel> matchedCrop = Crops.Where(crop => crop.ItemName.ToLower() == plannedCrop.ToLower())
                                                     .ToList();

                    if (matchedCrop.Count != 1)
                    {
                        throw new Exception($"Crop matching error. Matched crop count is: {matchedCrop.Count}");
                    }
                    else
                    {
                        newRotation.ProductId = matchedCrop[0].Id;
                        newField.Rotations.Add(newRotation);
                    }
                }
            }
            GlobalConfig.Connection.CreateRotation_Batch(newField.Rotations);
            Fields.Add(newField);
            IList<object> updateRow = new string[] { newField.Farm, newField.Field, newField.Id.ToString() };

            IdUpdateList.Add(updateRow);

        }

    }
}
