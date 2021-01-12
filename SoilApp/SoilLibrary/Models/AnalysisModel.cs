using System;
using System.Collections.Generic;

namespace SoilLibrary.Models
{
    public class AnalysisModel
    {
        /// <summary>
        /// Unique id from database
        /// </summary>
        public int Id { get; set; } = -1;
        /// <summary>
        /// Unique id for the product that this analysis is for
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Timestamp of when this analysis was created/recorded
        /// </summary>
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Unique name given to this analyiss
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// List of nutrient levels in this analysis
        /// </summary>
        public List<SoilSampleNutrientModel> Nutrients { get; set; }

        public AnalysisModel()
        {
        }
    }
}
