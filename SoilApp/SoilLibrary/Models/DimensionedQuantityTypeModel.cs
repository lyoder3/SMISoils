namespace SoilLibrary.Models
{
    public class DimensionedQuantityTypeModel : IDimensionedQuantityTypeModel
    {
        /// <summary>
        /// Type id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Type name
        /// </summary>
        public string Type { get; set; }
    }
}
