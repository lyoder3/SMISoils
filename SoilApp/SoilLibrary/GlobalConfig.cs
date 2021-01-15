using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using OfficeOpenXml;
using SoilLibrary.DataAccess;
using System;
using System.Configuration;
using System.IO;
using System.Threading;

namespace SoilLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        private static UserCredential GoogleCreds { get; set; }
        public static SheetsService SheetsService { get; private set; }
        public static IMasterSheet MasterSheet { get; private set; }

        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };

        public static void Initialize()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            SQLConnector sql = new SQLConnector();
            Connection = sql;
            GoogleCreds = GoogleCredentials();
            SheetsService = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = GoogleCreds,
                ApplicationName = "SMI Soils"
            });

            MasterSheet = new MasterSheet();
            
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        private static UserCredential GoogleCredentials()
        {
            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token1.json";
                UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
                return credential;
            }
        }
    }
}
