using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoilLibrary.DataAccess;
using EPPlusTest;
using OfficeOpenXml;
using SoilLibrary.Models;
using System.IO;

namespace SoilLibrary.Utilities
{
    public static class ExcelWriter
    {
        public static void WriteSoilData(Dictionary<string, object> parameters)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string folderPath = (string)parameters["FolderPath"];

            int rotationYear = Convert.ToInt32(parameters["RotationYear"]);
            ProductModel crop = (ProductModel)parameters["Crop"];
            string farmName = (string)parameters["FarmName"];
            NutrientModel nutrient = (NutrientModel)parameters["Nutrient"];

            stringBuilder.Append(rotationYear);
            stringBuilder.Append(crop.ItemName);
            stringBuilder.Append(farmName);
            stringBuilder.AppendFormat(nutrient.ItemName);
            stringBuilder.Append(".xlsx");

            string outputFileName = stringBuilder.ToString();

            DirectoryInfo directory = new DirectoryInfo(folderPath);

            FileInfo newFile = FileOutputUtil.GetFileInfo(directory, outputFileName, deleteIfExists: true);

            string[] headers = new string[]
            { 
                "Farm",
                "Field",
                "Nutrient",
                "Amount (lbm/ac)",
                "Goal (lbm/ac)",
                "Last Sampled",
                $"{rotationYear} Crop"
            };

            using (var package = new ExcelPackage(newFile))
            {
                IList<FilteredFieldNutrientModel> models = GlobalConfig.Connection.GetFieldsNutrients_Filter(
                        farmName: farmName,
                        rotationYear: rotationYear,
                        nutrientId: nutrient.Id,
                        productId: crop.Id
                    );
                var newSheet = package.Workbook.Worksheets.Add("Results");
                for (int i = 0; i < headers.Length; i++)
                {
                    newSheet.Cells[1, i+1].Value = headers[i];
                }
                
                var newRange = newSheet.Cells["A2"].LoadFromCollection(models);

                newRange.AutoFitColumns();

                package.Save();
            }
        }

        public static void WriteSoilSampleIntentions(Dictionary<string, object> parameters)
        {
            //TODO - Finish writing these files
            StringBuilder stringBuilder = new StringBuilder();

            string folderPath = (string) parameters["FolderPath"];

            int rotationYear = Convert.ToInt32(parameters["RotationYear"]);
            ProductModel crop = (ProductModel)parameters["Crop"];

            int lastSampledYear = Convert.ToInt32(parameters["LastSampled"]);

            stringBuilder.Append(rotationYear);
            stringBuilder.Append(crop.ItemName);
            stringBuilder.Append("SoilSampleIntentions");
            stringBuilder.Append(".xlsx");

            string[] headers = new string[]
            {
                "id",
                "Farm",
                "Field",
                "Rotation Year",
                "Crop",
            };

            string outputFileName = stringBuilder.ToString();

            DirectoryInfo directory = new DirectoryInfo(folderPath);

            FileInfo newFile = FileOutputUtil.GetFileInfo(directory, outputFileName, deleteIfExists: true);

            using (var package = new ExcelPackage(newFile))
            {
                IList<SoilSampleIntentionsModel> intentions = GlobalConfig.Connection
                                                .GetSoilSampleIntentions(lastSampledYear, rotationYear, crop.Id);
                
                var newSheet = package.Workbook.Worksheets.Add("Results");
                for (int i = 0; i < headers.Length; i++)
                {
                    newSheet.Cells[1, i + 1].Value = headers[i];
                }

                var newRange = newSheet.Cells["A2"].LoadFromCollection(intentions);

                newRange.AutoFitColumns();

                package.Save();

            }
        }
    }
}
