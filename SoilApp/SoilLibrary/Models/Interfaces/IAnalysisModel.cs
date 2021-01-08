using System;
using System.Collections.Generic;

namespace SoilLibrary.Models
{
    public interface IAnalysisModel
    {
        string Name { get; set; }
        List<NutrientModel> Nutrients { get; set; }
        int ProductId { get; set; }
        DateTime Timestamp { get; set; }
    }
}