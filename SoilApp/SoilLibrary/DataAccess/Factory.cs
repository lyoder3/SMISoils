using SoilLibrary.Utilities;

namespace SoilLibrary.DataAccess
{
    public class Factory
    {
        public static IGoogleSheet CreateGoogleSheet(string spreadsheetId = "")
        {
            return new GoogleSheet(spreadsheetId);
        }
    }
}
