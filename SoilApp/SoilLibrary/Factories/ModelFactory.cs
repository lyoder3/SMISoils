using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoilLibrary.Models;

namespace SoilLibrary.Factories
{
    public static class ModelFactory
    {
        public static IFieldModel CreateFieldModel(string farm = "",string field = "",int id = 0)
        {
            IFieldModel newField = new FieldModel
            {
                Farm = farm,
                Field = field,
                Id = id
            };
            return newField;
        }
        public static IUnitModel CreateUnitModel(string unit = "", int id = 0)
        {
            IUnitModel newUnit = new UnitModel()
            {
                Unit = unit,
                Id = id
            };
            return newUnit;
        }
    }
}
