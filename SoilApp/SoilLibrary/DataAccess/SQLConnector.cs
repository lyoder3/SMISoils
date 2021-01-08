using Dapper;
using SoilLibrary.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SoilLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        private const string db = "Soil";
        public AnalysisModel CreateAnalysis(AnalysisModel model)
        {
            throw new System.NotImplementedException();
        }

        public DimensionedQuantityModel CreateDimensionedQuantity(DimensionedQuantityModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@QuantityName", model.ItemName);
                p.Add("@UnitId", model.UnitId);
                p.Add("@TypeId", model.TypeId);
                p.Add("@id", model.Id, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("dbo.spDimensionedQuantities_Insert", p, 
                    commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public FieldModel CreateField(FieldModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FarmName", model.Farm);
                p.Add("@Field", model.Field);
                p.Add("@id", model.Id, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("dbo.spFields_Upsert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public OperationModel CreateOperation(OperationModel model)
        {
            throw new System.NotImplementedException();
        }

        public RotationModel CreateRotation(RotationModel model)
        {
            throw new System.NotImplementedException();
        }

        public void CreateRotation_Batch(List<RotationModel> models)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Soil")))
            {
                connection.Execute("dbo.spRotations_Upsert", models, commandType:CommandType.StoredProcedure);
            }
        }

        public SoilSampleModel CreateSoilSample(SoilSampleModel model)
        {
            throw new System.NotImplementedException();
        }

        public UnitModel CreateUnit(UnitModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Soil")))
            {
                var p = new DynamicParameters();
                p.Add("@Unit", model.Unit);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                try
                {
                    connection.Execute("dbo.spUnits_Insert", p,
                        commandType: CommandType.StoredProcedure);
                }
                catch (SqlException e)
                {
                    throw new System.Exception(e.Message);
                }
                model.Id = p.Get<int>("@id");
                return model;
            }
            

            
        }

        public int GetDimensionedQuantityTypeId_ByName(string name)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Type", name);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDimensionedTypes_GetByName", p, commandType: CommandType.StoredProcedure);

                return p.Get<int>("@id");
            }
        }

        public List<DimensionedQuantityTypeModel> GetDimensionedQuantityType_All()
        {
            List<DimensionedQuantityTypeModel> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {

                output = connection.Query<DimensionedQuantityTypeModel>
                    ("dbo.spDimensionedTypes_GetAll").ToList();

            }
            return output;
        }

        public List<DimensionedQuantityModel> GetDimensionedQuantity_ByType(int typeId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TypeId", typeId);

                return connection.Query<DimensionedQuantityModel>("dbo.spDimensionedQuantities_GetAlLByType", p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<UnitModel> GetUnit_All()
        {
            List<UnitModel> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<UnitModel>
                    ("dbo.spUnits_GetAll").ToList();
            }
            return output;
        }
    }
}