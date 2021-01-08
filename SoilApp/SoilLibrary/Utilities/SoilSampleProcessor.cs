using SoilLibrary.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoilLibrary.Utilities
{
    public class SoilSampleProcessor : ICSVProcessor
    {
        public IList<string> FilePaths { get; set; } = new List<string>();
        public List<List<string>> Lines { get; set; }

        public List<List<string>> ReadValues()
        {
            List<List<string>> allLines = new List<List<string>>();

            foreach (var file in FilePaths)
            {
                List<string> lines = File.ReadAllLines(file).ToList();
                foreach (var line in lines)
                {
                    allLines.Add(line.Split(',').ToList());
                }
            }
            Lines = allLines;

            return allLines;
        }
        public IList<SoilSampleModel> Process()
        {
            // TODO - Write code to process soil sample files

            return new List<SoilSampleModel>();
        }
    }
}
