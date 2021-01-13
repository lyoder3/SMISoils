using SoilLibrary.Models;
using System.Collections.Generic;

namespace SoilLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateField(FieldModel model);
        void CreateRotation_Batch(IList<RotationModel> models);
        void CreateField_andRotations(IList<FieldModel> models);
        void CreateNutrient(NutrientModel model);
        void CreateProduct(ProductModel model);
        void CreateAnalysis(AnalysisModel model);
        void CreateOperation(OperationModel model);
        void CreateSoilSample(SoilSampleModel model);
        void CreateSampleNutrients_Batch(IList<SoilSampleNutrientModel> models);
        void CreateUnit(UnitModel model);
        IList<UnitModel> GetUnits_All();
        UnitModel GetUnit_ById(int unitId);

        IList<ProductModel> GetProducts_All();

        IList<NutrientModel> GetNutrients_All();
        NutrientModel GetNutrient_ById(int nutrientId);

        IList<AnalysisModel> GetAnalyses_ByProductId(int productId);

    }
}