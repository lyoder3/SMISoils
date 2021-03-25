using SoilLibrary.Models;
using System.Collections.Generic;

namespace SoilLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateField(FieldModel model);
        void CreateNutrient(NutrientModel model);
        void CreateProduct(ProductModel model);
        void CreateAnalysis(AnalysisModel model);
        void CreateOperation(OperationModel model);
        void CreateSoilSample(SoilSampleModel model);
        void CreateUnit(UnitModel model);
        IList<UnitModel> GetUnits_All();
        UnitModel GetUnit_ById(int unitId);

        IList<ProductModel> GetProducts_All();

        IList<NutrientModel> GetNutrients_All();
        NutrientModel GetNutrient_ById(int nutrientId);

        IList<AnalysisModel> GetAnalyses_ByProductId(int productId);
        IList<FieldModel> GetFields(string farmName);

        IList<int> GetRotationYears();

        IList<FilteredFieldNutrientModel> GetFieldsNutrients_Filter(string farmName, int rotationYear, int nutrientId, int productId);
        IList<SoilSampleIntentionsModel> GetSoilSampleIntentions(int lastSampled, int rotationYear, int productId);
        void CreateSoilSampleNutrient(SoilSampleNutrientModel model);
        void CreateFieldNutrient(SoilSampleNutrientModel model, int fieldId, int lastSampleYear);

        SoilSampleNutrientModel GetFieldNutrient_ByIds(int fieldId, int nutrientId);
        IList<FieldNutrientOutputModel> GetFieldNutrients_All();

    }
}