using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoilLibrary.Utilities
{
    public class SoilSampleColumnProcessor
    {
        private static readonly Regex NutrientRegex = new Regex("(?<NutrientId>\\d{2})$");
        private static readonly Regex FieldIdRegex = new Regex("^Field");
        private static readonly Regex NutrientRecRegex = new Regex("(?<NutrientId>\\d{2}) Rec (?<RecNum>\\d)");
        private static readonly Regex YearRegex = new Regex("^Year");
        private List<string> Headers { get; set; }
        public int FieldIndex { get; set; }
        public int YearIndex { get; set; }
        public Dictionary<string, int> RecommendationMappings { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, int> NutrientMappings { get; set; } = new Dictionary<string, int>();

        public SoilSampleColumnProcessor(List<string> headers)
        {
            Headers = headers;
        }
        public void MapColumns()
        {
            foreach (var header in Headers)
            {
                if (NutrientRegex.IsMatch(header))
                {
                    string nutrientId = NutrientRegex.Match(header).Groups["NutrientId"].Value;
                    int columnIndex = Headers.IndexOf(header);
                    NutrientMappings.Add(nutrientId, columnIndex);
                }
                if (NutrientRecRegex.IsMatch(header))
                {
                    string columnName = NutrientRecRegex.Match(header).Groups["NutrientId"].Value;
                    string recNum = NutrientRecRegex.Match(header).Groups["RecNum"].Value;
                    int columnIndex = Headers.IndexOf(header);
                    RecommendationMappings.Add($"{columnName} Rec {recNum}", columnIndex);
                }
                if (FieldIdRegex.IsMatch(header))
                {
                    int columnIndex = Headers.IndexOf(header);
                    FieldIndex = columnIndex;
                }
                if (YearRegex.IsMatch(header))
                {
                    int columnIndex = Headers.IndexOf(header);
                    YearIndex = columnIndex;
                }
            }
        }
    }
}