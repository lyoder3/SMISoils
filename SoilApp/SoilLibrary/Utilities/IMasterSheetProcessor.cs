using SoilLibrary.Models;
using System.Collections.Generic;

namespace SoilLibrary.Utilities
{
    public interface IMasterSheetProcessor
    {
        IList<IList<object>> Process(IList<IList<object>> rows);
        void ProcessRow(IList<object> row);
        void BuildFarmName(FieldModel newField, string key, IList<object> row);
        void BuildFieldName(FieldModel newField, string key, IList<object> row);
        void BuildId(FieldModel newField, string key, IList<object> row);
        int ExtractYear(object value);
        bool FieldModelColumnsExist();
        IDictionary<string, int> GetRelevantColumns(IList<object> headers);
        IDictionary<int, int> GetRotationColumns();
        bool IsFarmName(object value);
        bool IsFieldName(object header);
        bool IsId(object header);
        bool IsRelevantColumn(object header);
        bool IsRotation(object header);
        bool ValidField(IList<object> row);
    }
}