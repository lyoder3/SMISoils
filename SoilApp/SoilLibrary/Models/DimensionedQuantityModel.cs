namespace SoilLibrary.Models
{
    public class DimensionedQuantityModel
    {
        public int Id { get; set; } = -1;
        public int TypeId { get; set; }

        public int UnitId { get; set; }

        public string ItemName { get; set; }
    }
}