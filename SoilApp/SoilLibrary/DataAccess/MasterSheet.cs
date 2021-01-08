using SoilLibrary.Models;
using SoilLibrary.Utilities;
using System.Collections.Generic;

namespace SoilLibrary.DataAccess
{
    public static class MasterSheet
    {
        private static readonly string SpreadsheetId = "1AUMOHvJnfGT5Ve1Ep-ECslC9bhj8sP0DAI64CmQ-iWw";

        private static readonly IGoogleSheet GoogleSheet = Factory.CreateGoogleSheet(SpreadsheetId);

        private static readonly string SheetRange = "'Master Sheet'";

        public static List<FieldModel> Fields = new List<FieldModel>();

        public static void UpsertFieldsAndRotations()
        {

            var rows = GoogleSheet.GetValues(SheetRange);

            IList<IList<object>> idUpdateRows = MasterSheetProcessor.Process(rows);

            UpdateFieldIds(idUpdateRows);
        }

        public static void UpdateFieldIds(IList<IList<object>> values)
        {
            GoogleSheet.WriteValues(values, "DatabaseIds!A1");
        }
    }
}
