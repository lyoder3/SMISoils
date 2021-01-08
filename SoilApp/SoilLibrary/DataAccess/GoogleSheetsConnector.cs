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
    public class GoogleSheetsConnector : IGoogleSheetConnection
    {
        
        static readonly string ApplicationName = "SMI Soils App";
        static readonly SheetsService Service = new SheetsService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = ConnectionHelper.GoogleCredentials(),
            ApplicationName = ApplicationName
        });
        public string SpreadsheetId { get; private set; }

        public GoogleSheetsConnector(string spreadsheetId)
        {
            SpreadsheetId = spreadsheetId;
        }
        public IList<IList<Object>> GetSheetValues(string sheetRange)
        {
            IGoogleSheetConnection gs = new GoogleSheetsConnector(SpreadsheetId);

            SpreadsheetsResource.ValuesResource.GetRequest request =
                Service.Spreadsheets.Values.Get(SpreadsheetId, sheetRange);

            ValueRange response = request.Execute();

            IList<IList<Object>> values = response.Values;

            if (values != null && values.Count > 0)
            {
                return values;
            }else
            {
                throw new Exception("Request returned empty values. Check spreadsheet ID and sheet range");
            }
        }

        public void WriteValuesToRange(List<IList<object>> values, string sheetRange)
        {
            ValueRange updateRange = new ValueRange();
            updateRange.Range = sheetRange;
            updateRange.Values = values;

            SpreadsheetsResource.ValuesResource.UpdateRequest request = Service.Spreadsheets
                .Values.Update(updateRange, SpreadsheetId, updateRange.Range);
            request.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            UpdateValuesResponse response = request.Execute();

            if (response.UpdatedCells == values[0].Count)
            {
                return;
            }

        }
    }
}
