using System;
using System.Collections.Generic;

namespace SoilLibrary.Models
{
    public class SoilSampleModel : ITimeboundObject
    {
        /// <summary>
        /// Unique id for this object from database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id for field this soil sample is associated with
        /// </summary>
        public int FieldId { get; set; }
        /// <summary>
        /// Timestamp for when soil sample was taken
        /// </summary>
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// List of nutrient objects and their respective data for the sample
        /// </summary>
        public List<NutrientModel> Nutrients { get; set; }
    }
}
