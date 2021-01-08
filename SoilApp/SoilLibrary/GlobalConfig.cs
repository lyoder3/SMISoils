using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoilLibrary.DataAccess;
using SoilLibrary.Utilities;
using System.Configuration;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using System.IO;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Services;

namespace SoilLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        private static UserCredential GoogleCreds { get; set; }
        public static SheetsService SheetsService { get; private set; }

        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        
        public static void InitializeConnection()
        {
            SQLConnector sql = new SQLConnector();
            Connection = sql;
            GoogleCreds = GoogleCredentials();
            SheetsService = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = GoogleCreds,
                ApplicationName = "SMI Soils"
            });

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
                string credPath = "token.json";
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
