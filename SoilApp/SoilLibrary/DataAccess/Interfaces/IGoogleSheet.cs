using System.Collections.Generic;

namespace SoilLibrary.Utilities
{
    public interface IGoogleSheet
    {
        IList<IList<object>> GetValues(string sheetRange);
        void WriteValues(IList<IList<object>> values, string sheetRange);
    }
}