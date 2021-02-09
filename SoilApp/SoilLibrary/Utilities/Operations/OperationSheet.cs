using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Utilities
{
    public class OperationSheet
    {
        public IGoogleSheetConnector GoogleSheet { get; set; }
        public OperationSheetProcessor processor { get; set; }

        private static readonly string SpreadsheetId = "1ycTM5ISQkRYcsZcpaqcP470GSmHc01dQzCObBq26Zz4";
        private static readonly string SheetRange = "Intentions";

        public OperationSheet()
        {
            GoogleSheet = new GoogleSheetConnector();
            IList<IList<object>> rows = GoogleSheet.GetValues(SpreadsheetId, SheetRange);
            processor = new OperationSheetProcessor(rows);
        }

        public void InsertOperations()
        {
            processor.ProcessRows();

            GoogleSheet.WriteValues(processor.UpdateValues, SpreadsheetId, SheetRange);
        }
    }
}
