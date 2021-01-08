namespace SoilLibrary.Models
{
    public interface IDimensionedQuantityModel : IDatabaseObjectModel
    {
        /// <summary>
        /// Quantity type Id 
        /// </summary>
        int TypeId { get; set; }
        /// <summary>
        /// Id from database for units the quantity is handled in
        /// </summary>
        int UnitId { get; set; }
        /// <summary>
        /// Name of quantity
        /// </summary>
        string ItemName { get; set; }
    }
}