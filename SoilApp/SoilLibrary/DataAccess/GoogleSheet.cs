using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using SoilLibrary.DataAccess;

namespace SoilLibrary.Utilities
{
    public class GoogleSheet
    {

        static readonly SheetsService Service = GlobalConfig.SheetsService;
        private readonly GoogleSheetConnector GSConnection;

        public GoogleSheet(string spreadsheetId)
        {
            GSConnection = new GoogleSheetConnector(spreadsheetId);
        }

        public IList<IList<Object>> GetValues(string sheetRange)
        {
            return GSConnection.GetValues(sheetRange);
        }

        public void WriteValues(List<IList<object>> values, string sheetRange)
        {
            GSConnection.WriteValues(values, sheetRange);

        }
    }
}
