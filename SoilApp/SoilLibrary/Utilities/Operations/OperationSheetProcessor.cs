using SoilLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Utilities
{
    public class OperationSheetProcessor : GoogleSheetProcessor
    {
        private readonly int FieldIndex = 0;
        private readonly int AnalysisIndex = 1;
        private readonly int AmountIndex = 2;
        private readonly int TimestampIndex = 3;
        public OperationSheetProcessor(IList<IList<object>> rows)
        {
            Rows = rows;
            PopHeaders();
            UpdateValues.Add(Headers);
        }
        public override void ProcessRow(IList<object> row)
        {
            OperationModel operation = new OperationModel();
            operation.AnalysisId = Convert.ToInt32(row[AnalysisIndex]);
            operation.AppliedAmount = Convert.ToDecimal(row[AmountIndex]);
            operation.Timestamp = Convert.ToDateTime(row[TimestampIndex]);
            operation.FieldId = Convert.ToInt32(row[FieldIndex]);

            GlobalConfig.Connection.CreateOperation(operation);

            UpdateValues.Add(new string[] { "", "", "", "" });
        }

        public override void ProcessRows()
        {
            foreach (var row in Rows)
            {
                ProcessRow(row);
            }
        }
    }
}
