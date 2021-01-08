using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoilLibrary.Utilities
{
    public static class MasterSheetProcessor
    {
        private readonly static Regex FarmNameRegex = new Regex("^Farm");
        private readonly static Regex FieldNameRegex = new Regex("^Field");
        private readonly static Regex RotationRegex = new Regex("\\d{4} SPRING");
        private readonly static Regex IdRegex = new Regex("^id");
        public static Dictionary<string, int> GetRotationColumns(Dictionary<string, int> allColumns)
        {
            Dictionary<string, int> rotationColumns = new Dictionary<string, int>();

            foreach (var key in allColumns.Keys)
            {
                Regex yearRegex = new Regex("(\\d{4})");
                if (yearRegex.IsMatch(key))
                {
                    string rotationYear = yearRegex.Match(key).Groups[0].Value;
                    rotationColumns.Add(rotationYear, allColumns[key]);
                }
            }
            return rotationColumns;
        }
        public static Dictionary<string, int> GetRelevantColumns(IList<object> headers)
        {
            Dictionary<string, int> indices = new Dictionary<string, int>();
            foreach (string header in headers)
            {
                if (FarmNameRegex.IsMatch(header))
                {
                    indices.Add("Farm", headers.IndexOf(header));
                }
                if (FieldNameRegex.IsMatch(header))
                {
                    indices.Add("Field", headers.IndexOf(header));
                }
                if (IdRegex.IsMatch(header))
                {
                    indices.Add("Id", headers.IndexOf(header));
                }
                if (RotationRegex.IsMatch(header))
                {
                    indices.Add(header, headers.IndexOf(header));
                }
            }
            return indices;
        }

    }
}
