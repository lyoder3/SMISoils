using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;

namespace SoilLibrary.Utilities
{
    public class GoogleSheetConnector
    {
        public string SpreadsheetId { get; private set; }
 
        public GoogleSheetConnector(string spreadsheetId)
        {
            SpreadsheetId = spreadsheetId;
        }

        public IList<IList<Object>> GetValues(string sheetRange)
        {
            SpreadsheetsResource.ValuesResource.GetRequest request =
            GlobalConfig.SheetsService.Spreadsheets.Values.Get(SpreadsheetId, sheetRange);

            ValueRange response = request.Execute();

            IList<IList<Object>> values = response.Values;

            if (values != null && values.Count > 0)
            {
                return values;
            }
            else
            {
                throw new Exception("Request returned empty values. Check spreadsheet ID and sheet range");
            }
        }

        public void WriteValues(List<IList<Object>> values, string sheetRange)
        {
            ValueRange updateRange = new ValueRange
            {
                Range = sheetRange,
                Values = values
            };

            SpreadsheetsResource.ValuesResource.UpdateRequest request = GlobalConfig.SheetsService.Spreadsheets
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