using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Google.Apis.Auth.OAuth2;
using System.IO;
using Google.Apis.Sheets.v4;
using System.Threading;
using Google.Apis.Util.Store;

namespace SoilLibrary.Utilities
{
    public static class ConnectionHelper
    {
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static UserCredential GoogleCredentials()
        {
            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token3.json";
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
