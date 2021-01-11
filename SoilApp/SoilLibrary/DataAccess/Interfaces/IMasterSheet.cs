using SoilLibrary.Utilities;
using System.Collections.Generic;

namespace SoilLibrary.DataAccess
{
    public interface IMasterSheet
    {
        IGoogleSheetConnector GoogleSheet { get; set; }
        IMasterSheetProcessor Processor { get; set; }

        void UpdateFieldIds(IList<IList<object>> values);
        void UpsertFieldsAndRotations();
    }
}