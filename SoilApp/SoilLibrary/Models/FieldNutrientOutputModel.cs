using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Models
{
    public class FieldNutrientOutputModel
    {
        public string Farm { get; set; }
        public string Field { get; set; }
        public decimal Acreage { get; set; }
        public string Nutrient { get; set; }
        public decimal SoilSampleAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal Goal { get; set; }
        public int LastSampledYear { get; set; }

    }
}
