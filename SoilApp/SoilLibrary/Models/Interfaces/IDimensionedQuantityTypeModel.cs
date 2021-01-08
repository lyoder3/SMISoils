namespace SoilLibrary.Models
{
    public interface IDimensionedQuantityTypeModel : IDatabaseObjectModel
    {
        string Type { get; set; }
    }
}