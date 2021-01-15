using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoilLibrary.Utilities
{
    public class AnalysesSheetColumnProcessor
    {
        private static readonly Regex NutrientRegex = new Regex("^(?<NutrientId>\\d{1,2})$");
        private List<string> Headers { get; set; }
        public Dictionary<string, int> NutrientMappings { get; set; } = new Dictionary<string, int>();

        public AnalysesSheetColumnProcessor(List<string> headers)
        {
            Headers = headers;
        }
        public void MapColumns()
        {
            foreach (string header in Headers)
            {
                if (NutrientRegex.IsMatch(header))
                {
                    string nutrientId = NutrientRegex.Match(header).Groups["NutrientId"].Value;
                    int columnIndex = Headers.IndexOf(header);
                    NutrientMappings.Add(nutrientId, columnIndex);
                }
                
            }
        }
    }
}