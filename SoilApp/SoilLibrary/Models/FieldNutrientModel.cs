using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Models
{
    public class FieldNutrientModel
    {
        public int Id { get; set; }
        public int FieldId { get; set; }
        public int NutrientId { get; set; }
        public decimal Amount { get; set; }
    }
}
