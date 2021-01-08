using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using SoilLibrary.Utilities;

namespace SoilLibrary.DataAccess
{
    public interface IGoogleSheetConnection
    {
        string SpreadsheetId { get; }
        IList<IList<Object>> GetSheetValues(string sheetRange);
        void WriteValuesToRange(List<IList<object>> values, string sheeetRange);
    }
}
