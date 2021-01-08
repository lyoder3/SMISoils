using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;

namespace SoilLibrary.Utilities
{
    public class GoogleSheet : IGoogleSheet
    {

        static readonly SheetsService Service = GlobalConfig.SheetsService;
        private readonly GoogleSheetConnector GSConnection;

        public GoogleSheet()
        {

        }
        public GoogleSheet(string spreadsheetId)
        {
            GSConnection = new GoogleSheetConnector(spreadsheetId);
        }

        public IList<IList<Object>> GetValues(string sheetRange)
        {
            return GSConnection.GetValues(sheetRange);
        }

        public void WriteValues(IList<IList<object>> values, string sheetRange)
        {
            GSConnection.WriteValues(values, sheetRange);

        }
    }
}
