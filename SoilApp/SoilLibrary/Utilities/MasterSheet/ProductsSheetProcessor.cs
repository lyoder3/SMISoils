using SoilLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoilLibrary.Utilities
{
    public class ProductsSheetProcessor : GoogleSheetProcessor
    {
        public int ItemNameIndex { get; set; } = 1;
        public int UnitNameIndex { get; set; } = 2;
        public int UnitIdIndex { get; set; } = 3;
        public int IdIndex { get; set; } = 0;

        public ProductsSheetProcessor(IList<IList<object>> rows)
        {
            Rows = rows;
            PopHeaders();
        }

        public override void ProcessRow(IList<object> row)
        {
            bool idExists = int.TryParse((string)row[IdIndex], out int id);

            if (idExists == false)
            {
                id = 0;
            }
            
            int unitId = Convert.ToInt32(row[UnitIdIndex]);
            string itemName = (string)row[ItemNameIndex];

            ProductModel model = new ProductModel()
            {
                Id = id,
                UnitId = unitId,
                ItemName = itemName
            };

            GlobalConfig.Connection.CreateProduct(model);

            IList<object> updateRow = new object[]
            {

                model.Id,
                model.ItemName.ToString(),
                row[UnitNameIndex],
                model.UnitId
            };

            UpdateValues.Add(updateRow);
        }

        public override void ProcessRows()
        {
            UpdateValues.Add(Headers);
            foreach (IList<object> row in Rows)
            {
                ProcessRow(row);
            }
        }
    }
}
