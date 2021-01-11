using System;
using System.Collections.Generic;

namespace SoilLibrary.Models
{
    public class SoilSampleModel
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
        /// Year soil sample is for. SQL Database automatically enters
        /// current year if this isn't passed
        /// </summary>
        public int SampleYear { get; set; }
        /// <summary>
        /// List of nutrient objects and their respective data for the sample
        /// </summary>
        public List<NutrientModel> Nutrients { get; set; } = new List<NutrientModel>();
    }
}
