using System;

namespace SoilLibrary.Models
{
    public class NutrientModel : INutrientModel
    {
        public decimal Amount { get; set; }

        public int Goal { get; set; }

        public int Recommendation { get; set; }
        public string ItemName { get; set; }
        public int TypeId { get; set; }
        public int UnitId { get; set; }
        public int Id { get; set; }

        /// <summary>
        /// Constructor for creating blank objects of the class
        /// </summary>
        public NutrientModel()
        {
        }
        /// <summary>
        /// Constructor for creating objects with an amount
        /// In our data model, this is used when creating a nutrient
        /// object to be used in conjunction with an analysis of a product
        /// since products don't have goals or recommendations
        /// </summary>
        /// <param name="id">The id from the database for this record</param>
        /// <param name="nutrient">The name of the nutrient from the database</param>
        /// <param name="unitId">The id of the units that this nutrient is recorded in</param>
        /// <param name="amount">The amount of the nutrient in the product this object is attached to</param>
        public NutrientModel(int id, string nutrient, int unitId, decimal amount)
        {
            Id = id;
            ItemName = nutrient;
            UnitId = unitId;
            Amount = amount;
        }
        /// <summary>
        /// Creates a nutrient object that corresponds to the nutrient on a field level where
        /// the level of the nutrient as well as the recommended value for the nutrient from soil sampling
        /// matters. This method first calls the constructor above then adds in the two other properties specific
        /// to this use case
        /// </summary>
        /// <param name="id">Id from database</param>
        /// <param name="nutrient">Name of nutrient record</param>
        /// <param name="unitId">Id for units that numbers are recorded in</param>
        /// <param name="amount">Amount of the nutrient on the field</param>
        /// <param name="recommendation">Recommended level for the field</param>
        public NutrientModel(int id, string nutrient, int unitId, decimal amount,
            decimal recommendation) : this(id, nutrient, unitId, amount)
        {
            Recommendation = Convert.ToInt32(recommendation);
            Goal = Convert.ToInt32(recommendation - amount);
        }
    }
}
