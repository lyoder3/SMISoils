namespace SoilLibrary.Models
{
    public class RotationModel : IRotationModel
    {
        /// <summary>
        /// Unique id for this object from database
        /// (Stored in Rotations table with FKs to products and fields)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id for field this rotation object is associated with
        /// </summary>
        public int FieldId { get; set; }
        /// <summary>
        /// Product Id for the crop for this rotation 
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Year for this rotation
        /// </summary>
        public int Year { get; set; }
    }
}
