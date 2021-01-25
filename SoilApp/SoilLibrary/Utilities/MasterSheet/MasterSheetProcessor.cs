using SoilLibrary.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.Linq;

namespace SoilLibrary.Utilities
{
    public class MasterSheetProcessor : GoogleSheetProcessor, IMasterSheetProcessor
    {
        private MasterSheetColumnProcessor ColumnProcessor { get; set; }
        private IList<FieldModel> Fields { get; set; } = new List<FieldModel>() { };
        private IList<ProductModel> Crops { get; set; }
        public IList<IList<object>> IdUpdateList { get; private set; } = new List<IList<object>>();
        public int FieldNameIndex { get; set; }
        public int FarmNameIndex { get; set; }
        public int IdIndex { get; set; }
        private IDictionary<int, int> RotationColumns { get; set; }
        public int AcreageIndex { get; private set; }

        public MasterSheetProcessor(IList<IList<object>> rows)
        {
            Rows = rows;
            PopHeaders();
            Crops = GlobalConfig.Connection.GetProducts_All();
            ColumnProcessor = new MasterSheetColumnProcessor(Headers);
        }
        
        public override void ProcessRows()
        {
            ColumnProcessor.MapColumns();

            FieldNameIndex = ColumnProcessor.FieldNameIndex;
            FarmNameIndex = ColumnProcessor.FarmNameIndex;
            IdIndex = ColumnProcessor.IdIndex;
            RotationColumns = ColumnProcessor.RotationColumns;
            AcreageIndex = ColumnProcessor.AcreageIndex;

            foreach (var row in Rows)
            {
                ProcessRow(row);
            }
        }

        public override void ProcessRow(IList<object> row)
        {
            FieldModel newField = new FieldModel()
            {
                Field = (string)row[FieldNameIndex],
                Farm = (string)row[FarmNameIndex],
                Id = Convert.ToInt32(row[IdIndex]),
                Acreage = 0.0M
            };

            bool validDecimal = decimal.TryParse((string)row[AcreageIndex], out decimal acreage);

            if (validDecimal && acreage > 0)
            {
                newField.Acreage = acreage;
            }


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
                    ProductModel matchedCrop = Crops.Where(crop => crop.ItemName.ToLower() == plannedCrop.ToLower())
                                                     .ToList().First();

                    if (matchedCrop == null)
                    {
                        throw new Exception($"Crop matching error. Current crop count is: {plannedCrop}");
                    }
                    else
                    {
                        newRotation.ProductId = matchedCrop.Id;
                        newField.Rotations.Add(newRotation);
                    }
                }
            }
            GlobalConfig.Connection.CreateField(newField);
            Fields.Add(newField);
            IList<object> updateRow = new string[] { newField.Farm, newField.Field, newField.Id.ToString() };

            UpdateValues.Add(updateRow);

        }

    }
}
