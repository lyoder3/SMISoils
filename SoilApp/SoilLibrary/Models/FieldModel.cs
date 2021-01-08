using System;
using System.Collections.Generic;
using System.Text;

namespace SoilLibrary.Models
{
    public class FieldModel : IDatabaseObjectModel
    {
        /// <summary>
        /// Unique id for field record in database
        /// </summary>
        public int Id { get; set; } = -1;
        /// <summary>
        /// Farm name
        /// </summary>
        public string Farm { get; set; }
        /// <summary>
        /// Field name
        /// </summary>
        public string Field { get; set; }
        /// <summary>
        /// List of nutrient objects and their respective data for the field
        /// </summary>
        public List<NutrientModel> Nutrients { get; set; }
        /// <summary>
        /// List of rotation entries (historic and future)
        /// </summary>
        public List<RotationModel> Rotations { get; set; } = new List<RotationModel>();

        public FieldModel()
        {
        }
    }
}
