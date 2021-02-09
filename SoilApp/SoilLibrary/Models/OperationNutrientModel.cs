using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Models
{
    public class OperationNutrientModel
    {
        public int FieldId { get; set; }
        public int NutrientId { get; set; }
        public int OperationId { get; set; }
        public decimal AmountApplied { get; set; }
    }
}
