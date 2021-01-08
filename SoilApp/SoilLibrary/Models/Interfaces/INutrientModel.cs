namespace SoilLibrary.Models
{
    public interface INutrientModel : IDimensionedQuantityModel
    {
        /// <summary>
        /// The recommended amount of a nutrient to add to hit the goal
        /// </summary>
        decimal Amount { get; set; }
        /// <summary>
        /// The goal level for a nutrient on a field
        /// Amount + Recommendation = Goal
        /// </summary>
        int Goal { get; set; }
        /// <summary>
        /// The recommended amount of a nutrient to add to hit the goal
        /// </summary>
        int Recommendation { get; set; }
    }
}