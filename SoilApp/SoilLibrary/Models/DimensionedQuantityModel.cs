namespace SoilLibrary.Models
{
    public class DimensionedQuantityModel : IDatabaseObjectModel
    {
        /// <summary>
        /// Unique id from database for quantity
        /// </summary>
        public int Id { get; set; } = -1;
        /// <summary>
        /// Quantity type Id 
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// Id from database for units the quantity is handled in
        /// </summary>
        public int UnitId { get; set; }
        /// <summary>
        /// Name of quantity
        /// </summary>
        public string ItemName { get; set; }
    }
}