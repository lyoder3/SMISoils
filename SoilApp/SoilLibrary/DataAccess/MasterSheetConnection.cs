using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoilLibrary.Utilities;

namespace SoilLibrary.DataAccess
{
    public class MasterSheetConnection
    {
        private static string SpreadsheetId { get; set; } = "1AUMOHvJnfGT5Ve1Ep-ECslC9bhj8sP0DAI64CmQ-iWw";
        private static string SheetRange { get; set; } = "'Master Sheet'!A:AZ";

        public static IList<IList<Object>> GetValues()
        {
            return GoogleSheetConnection.GetGoogleSheet(SpreadsheetId, SheetRange);
        }
    }
}
