using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Models
{
    public interface IDatabaseObjectModel
    {
        /// <summary>
        /// Unique id from database
        /// </summary>
        int Id { get; set; }
    }
}
