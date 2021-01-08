using System.Collections.Generic;

namespace SoilLibrary.Models
{
    public interface IFieldModel : IDatabaseObjectModel
    {
        /// <summary>
        /// Farm name
        /// </summary>
        string Farm { get; set; }
        /// <summary>
        /// Field name
        /// </summary>
        string Field { get; set; }
        /// <summary>
        /// List of nutrient objects and their respective data for the field
        /// </summary>
        IList<INutrientModel> Nutrients { get; set; }
        /// <summary>
        /// List of rotation entries (historic and future)
        /// </summary>
        IList<IRotationModel> Rotations { get; set; }
    }
}