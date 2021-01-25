using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoilLibrary.Utilities
{
    public class MasterSheetColumnProcessor
    {
        private static readonly Regex FarmNameRegex = new Regex("^Farm");
        private static readonly Regex FieldNameRegex = new Regex("^Field");
        private static readonly Regex RotationRegex = new Regex("(?<RotationYear>\\d{4}) SPRING");
        private static readonly Regex IdRegex = new Regex("^Id");
        private static readonly Regex AcreageRegex = new Regex("^CROPPING ACRES$");

        private IList<object> Headers { get; set; }
        public int FieldNameIndex { get; set; }
        public int FarmNameIndex { get; set; }
        public int IdIndex { get; set; }
        public int AcreageIndex { get; set; }
        public IDictionary<int, int> RotationColumns { get; set; } = new Dictionary<int, int>();

        public MasterSheetColumnProcessor(IList<object> headers)
        {
            Headers = headers;
        }

        public void MapColumns()
        {
            foreach (string header in Headers)
            {
                if (FarmNameRegex.IsMatch(header))
                {
                    int columnIndex = Headers.IndexOf(header);
                    FarmNameIndex = columnIndex;
                }
                if (FieldNameRegex.IsMatch(header))
                {
                    int columnIndex = Headers.IndexOf(header);
                    FieldNameIndex = columnIndex;
                } 
                if (IdRegex.IsMatch(header))
                {
                    int columnIndex = Headers.IndexOf(header);
                    IdIndex = columnIndex;
                }
                if (RotationRegex.IsMatch(header))
                {
                    int columnIndex = Headers.IndexOf(header);
                    int rotationYear = Convert.ToInt32(RotationRegex.Match(header)
                        .Groups["RotationYear"].Value);
                    RotationColumns.Add(rotationYear, columnIndex);
                }
                if (AcreageRegex.IsMatch(header))
                {
                    int columnIndex = Headers.IndexOf(header);
                    AcreageIndex = columnIndex;
                }
                
            }
        }

    }
}
