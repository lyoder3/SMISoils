using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoilLibrary;
using SoilLibrary.Utilities;
using SoilLibrary.Models;
using System.IO;
using System.Text.RegularExpressions;

namespace SoilAppConsole
{
    class Program
    {
        private static readonly Regex NutrientRegex = new Regex("(?<NutrientId>\\d{2})$");
        private static readonly Regex FieldIdRegex = new Regex("^Field");
        private static readonly Regex NutrientRecRegex = new Regex("(?<NutrientId>\\d{2}) Rec (?<RecNum>\\d)");
        static void Main(string[] args)
        {
            string directory = @"C:\\Users\\loyod\\Desktop\\SMI\\soils\\2019\\raw_files";
            GlobalConfig.Initialize();

            var paths = Directory.GetFiles(directory).ToList();

            ISoilSampleProcessor processor = new SoilSampleProcessor(paths);

            processor.ProcessSamples();

            foreach (var soilSample in processor.Samples)
            {
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
