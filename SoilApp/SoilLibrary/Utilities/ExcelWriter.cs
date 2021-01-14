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
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            
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

            List<string> headers = new List<string>()
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
                newSheet.Cells["A1:G1"].Value = headers;
                var newRange = newSheet.Cells["A2"].LoadFromCollection(models);

                newRange.AutoFitColumns();

                package.Save();
            }
        }
    }
}
