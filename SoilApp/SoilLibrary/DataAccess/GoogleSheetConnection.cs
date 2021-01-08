using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoilLibrary.Utilities;

namespace SoilLibrary.DataAccess
{
    public static class GoogleSheetConnection
    {
        public static IList<IList<Object>> GetGoogleSheet(string spreadsheetId, string sheetRange) {

            return GoogleSheetsHelper.GetGoogleSheetValues(spreadsheetId, sheetRange);
        }
    }
}
