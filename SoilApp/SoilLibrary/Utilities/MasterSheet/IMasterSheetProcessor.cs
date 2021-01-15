using System.Collections.Generic;

namespace SoilLibrary.Utilities
{
    public interface IMasterSheetProcessor
    {
        int FarmNameIndex { get; set; }
        int FieldNameIndex { get; set; }
        int IdIndex { get; set; }
        IList<IList<object>> IdUpdateList { get; }
        void ProcessRow(IList<object> row);
    }
}