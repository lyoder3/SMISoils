namespace SoilLibrary.Models
{
    public interface IRotationModel : IDatabaseObjectModel
    {
        /// <summary>
        /// Id for field this rotation object is associated with
        /// </summary>
        int FieldId { get; set; }
        /// <summary>
        /// Product Id for the crop for this rotation 
        /// </summary>
        int ProductId { get; set; }
        /// <summary>
        /// Year for this rotation
        /// </summary>
        int Year { get; set; }
    }
}