using SoilLibrary.Models;
using System.Collections.Generic;

namespace SoilLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateField(FieldModel model);
        void CreateRotation_Batch(IList<RotationModel> models);
        void CreateField_andRotations(IList<FieldModel> models);
        void CreateDimensionedQuantity(DimensionedQuantityModel model);
        void CreateAnalysis(AnalysisModel model);
        void CreateOperation(OperationModel model);
        void CreateSoilSample(SoilSampleModel model);
        void CreateSampleNutrients_Batch(IList<NutrientModel> models);
        void UpsertFieldsNutrients(IList<NutrientModel> models);
        void CreateUnit(UnitModel model);

        IList<DimensionedQuantityTypeModel> GetDimensionedQuantityType_All();
        int GetDimensionedQuantityTypeId_ByName(string name);

        IList<UnitModel> GetUnit_All();

        IList<DimensionedQuantityModel> GetDimensionedQuantity_ByType(int typeId);


    }
}