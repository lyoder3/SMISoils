using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Models
{
    public class DimensionedQuantityTypeModel : IDatabaseObjectModel
    {
        /// <summary>
        /// Type id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Type name
        /// </summary>
        public string Type { get; set; }
    }
}
