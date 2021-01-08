using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Models
{
    public interface ITimeboundObject : IDatabaseObjectModel
    {
        /// <summary>
        /// A timestamp for this record
        /// </summary>
        DateTime Timestamp { get; set; }
    }
}
