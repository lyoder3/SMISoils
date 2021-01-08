using SoilLibrary.Models;
using System.Collections.Generic;

namespace SoilLibrary.DataAccess
{
    public interface IDataConnection
    {
        FieldModel CreateField(FieldModel model);
        void CreateRotation_Batch(List<RotationModel> models);
        DimensionedQuantityModel CreateDimensionedQuantity(DimensionedQuantityModel model);
        AnalysisModel CreateAnalysis(AnalysisModel model);
        OperationModel CreateOperation(OperationModel model);
        SoilSampleModel CreateSoilSample(SoilSampleModel model);

        List<DimensionedQuantityTypeModel> GetDimensionedQuantityType_All();
        int GetDimensionedQuantityTypeId_ByName(string name);
        UnitModel CreateUnit(UnitModel model);
        List<UnitModel> GetUnit_All();

        List<DimensionedQuantityModel> GetDimensionedQuantity_ByType(int typeId);

        
    }
}