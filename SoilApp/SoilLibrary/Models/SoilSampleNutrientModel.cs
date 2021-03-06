﻿using System;

namespace SoilLibrary.Models
{
    public class SoilSampleNutrientModel
    {
        /// <summary>
        /// 2 million lbs of dirt / ac. Soil sample nutrient levels are given in 
        /// ppm/ac, so 2 * ppm value equals lbm/ac. 
        /// </summary>
        public readonly static int PPMConversionFactor = 2;
        public int Id { get; set; }
        public int NutrientId { get; set; }
        public int SoilSampleId { get; set; }
        public decimal? Amount { get; set; }

        public decimal? Recommendation { get; set; }

        public int? Goal { get; set; }
        /// <summary>
        /// Constructor for creating blank objects of the class
        /// </summary>
        public SoilSampleNutrientModel()
        {
        }
    }
}
