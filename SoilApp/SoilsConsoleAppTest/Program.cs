using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoilLibrary.Models;
using SoilLibrary.DataAccess;
using SoilLibrary;
using System.IO;
using SoilLibrary.Utilities;

namespace SoilsConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.InitializeConnection();

            Console.WriteLine("Enter path to the folder with csv files");
            string path = Console.ReadLine();

            List<string> files = Directory.GetFiles(path).ToList();
            Console.WriteLine("You selected the following files:");

            foreach (var file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            SoilSampleProcessor processor = new SoilSampleProcessor();

            processor.FilePaths = files;

            processor.ReadValues();

            foreach (var line in processor.Lines)
            {
                Console.WriteLine(JoinArray(line));
            }


            Console.Write("Press Enter to exit...");
            Console.ReadLine();
        }

        private static string JoinArray(List<string> input)
        {
            return String.Join(",", input);
        }
    }
}
