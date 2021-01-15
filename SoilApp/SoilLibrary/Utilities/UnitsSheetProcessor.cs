using SoilLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Utilities
{
    public class UnitsSheetProcessor : GoogleSheetProcessor
    {

        public int UnitNameIndex { get; set; } = 1;
        public int IdIndex { get; set; } = 0;

        public UnitsSheetProcessor(IList<IList<object>> rows)
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
            string unitName = (string)row[UnitNameIndex];

            UnitModel model = new UnitModel()
            {
                Id = id,
                Unit = unitName
            };

            GlobalConfig.Connection.CreateUnit(model);

            IList<object> updateRow = new object[]
            {

                model.Id,
                model.Unit.ToString()
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
