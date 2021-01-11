using System.Collections.Generic;

namespace SoilLibrary.Utilities
{
    public interface IGoogleSheetConnector
    {
        IList<IList<object>> GetValues(string spreadsheetId, string sheetRange);
        void WriteValues(IList<IList<object>> values, string spreadsheetId, string sheetRange);
    }
}