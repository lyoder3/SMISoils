using SoilLibrary.Models;
using System.Collections.Generic;

namespace SoilLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateField(IFieldModel model);
        void CreateRotation_Batch(IList<IRotationModel> models);
        void CreateDimensionedQuantity(IDimensionedQuantityModel model);
        void CreateAnalysis(IAnalysisModel model);
        void CreateOperation(OperationModel model);
        void CreateSoilSample(SoilSampleModel model);
        void CreateUnit(IUnitModel model);

        IList<DimensionedQuantityTypeModel> GetDimensionedQuantityType_All();
        int GetDimensionedQuantityTypeId_ByName(string name);

        IList<UnitModel> GetUnit_All();

        IList<DimensionedQuantityModel> GetDimensionedQuantity_ByType(int typeId);


    }
}