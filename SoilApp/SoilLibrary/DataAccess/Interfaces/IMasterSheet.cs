using SoilLibrary.Utilities;
using System.Collections.Generic;

namespace SoilLibrary.DataAccess
{
    public interface IMasterSheet
    {
        IGoogleSheetConnector GoogleSheet { get; set; }

        void Update(MasterSheetTab sheetTab);
        void UpsertFieldsAndRotations();
        void UpsertUnits();
        void WriteNutrientLevels();
    }
}