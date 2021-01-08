using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Models
{
    public class UnitModel : IDatabaseObjectModel
    {
        public int Id { get; set; }
        public string Unit { get; set; }
    }
}
