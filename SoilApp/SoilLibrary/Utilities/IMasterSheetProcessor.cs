using System.Collections.Generic;

namespace SoilLibrary.Utilities
{
    public interface IMasterSheetProcessor
    {
        int FarmNameIndex { get; set; }
        int FieldNameIndex { get; set; }
        int IdIndex { get; set; }
        IList<IList<object>> IdUpdateList { get; }

        void PopHeaders();
        void ProcessRow(IList<object> row);
        void ProcessRows();
    }
}