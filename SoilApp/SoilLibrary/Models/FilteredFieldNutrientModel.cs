using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Models
{
    public class FilteredFieldNutrientModel
    {
        public string Farm { get; set; }
        public string Field { get; set; }
        public string ItemName { get; set; }
        public string Nutrient { get; set; }
        public decimal Amount { get; set; }
        public int Goal { get; set; }
        public string Crop { get; set; }
    }
}
