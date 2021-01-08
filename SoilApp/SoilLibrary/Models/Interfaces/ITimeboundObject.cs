using System;

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
