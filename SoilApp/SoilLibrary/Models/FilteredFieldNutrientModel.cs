using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Models
{
    public class FilteredFieldNutrientModel
    {
        public int Id { get; set; }
        public string Farm { get; set; }
        public string Field { get; set; }
        public decimal Acreage { get; set; }
        public string Nutrient { get; set; }
        public decimal Amount { get; set; }
        public int Goal { get; set; }
        public int LastSampled { get; set; }
        public string LastCrop { get; set; }
        public string UpcomingCrop { get; set; }
    }
}
