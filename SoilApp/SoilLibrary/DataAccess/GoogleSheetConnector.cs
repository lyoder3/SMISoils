using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using SoilLibrary.Exceptions;
using System;
using System.Collections.Generic;

namespace SoilLibrary.Utilities
{
    public class GoogleSheetConnector : IGoogleSheetConnector
    {

        public IList<IList<object>> GetValues(string spreadsheetId, string sheetRange)
        {
            SpreadsheetsResource.ValuesResource.GetRequest request =
            GlobalConfig.SheetsService.Spreadsheets.Values.Get(spreadsheetId, sheetRange);

            ValueRange response = request.Execute();

            IList<IList<object>> values = response.Values;

            if (values != null && values.Count > 0)
            {
                return values;
            }
            else
            {
                throw new Exception("Request returned empty values. Check spreadsheet ID and sheet range");
            }
        }

        public void WriteValues(IList<IList<object>> values, string spreadsheetId, string sheetRange)
        {
            ValueRange updateRange = new ValueRange
            {
                Range = sheetRange,
                Values = values,
            };

            SpreadsheetsResource.ValuesResource.UpdateRequest request = GlobalConfig.SheetsService.Spreadsheets
                .Values.Update(updateRange, spreadsheetId, updateRange.Range);
            request.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;

            try
            {
                UpdateValuesResponse response = request.Execute();
            }
            catch (Exception ex)
            {
                throw new GoogleSheetUpdateException("Failed to write values to Google Sheet");
            }
        }
    }
}