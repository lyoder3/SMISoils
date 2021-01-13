using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Models
{
    public class AnalysisNutrientModel
    {
        /// <summary>
        /// 2 million lbs of dirt / ac. Soil sample nutrient levels are given in 
        /// ppm/ac, so 2 * ppm value equals lbm/ac. 
        /// </summary>
        public readonly static int PPMConversionFactor = 2;
        public int Id { get; set; }
        public int NutrientId { get; set; }
        public int AnalysisId { get; set; }
        public decimal Amount { get; set; }

        public override string ToString()
        {
            string nutrientName = GlobalConfig.Connection.GetNutrient_ById(NutrientId).ItemName;
            return $"{nutrientName},{Amount}";
        }
    }
}
