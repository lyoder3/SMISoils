using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Models
{
    public class SoilSampleIntentionsModel
    {
        public int Id { get; set; }
        public string Farm { get; set; }
        public string Field { get; set; }
        public int RotationYear { get; set; }
        public string Crop { get; set; }
    }
}
