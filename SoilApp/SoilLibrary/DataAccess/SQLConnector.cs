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

        public void CreateAnalysis(AnalysisModel model)
        {
            throw new System.NotImplementedException();
        }

        public void CreateDimensionedQuantity(DimensionedQuantityModel model)
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
            }
        }

        public void CreateField(FieldModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FarmName", model.Farm);
                p.Add("@Field", model.Field);
                p.Add("@id", model.Id, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("dbo.spFields_Upsert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public void CreateField_andRotations(IList<FieldModel> models)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
            }
        }

        public void CreateOperation(OperationModel model)
        {
            throw new System.NotImplementedException();
        }

        public void CreateRotation_Batch(IList<RotationModel> models)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Execute("dbo.spRotations_Upsert", models, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateSampleNutrients_Batch(IList<NutrientModel> models)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Execute("dbo.spSoilSamplesNutrients_Insert", models, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateSoilSample(SoilSampleModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FieldId", model.FieldId);
                p.Add("@SampleYear", model.SampleYear);
                p.Add("@id", model.Id, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                connection.Execute("dbo.spSoilSamples_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public void CreateUnit(UnitModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
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

        public IList<DimensionedQuantityTypeModel> GetDimensionedQuantityType_All()
        {
            IList<DimensionedQuantityTypeModel> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {

                output = connection.Query<DimensionedQuantityTypeModel>
                    ("dbo.spDimensionedTypes_GetAll").ToList();

            }
            return output;
        }

        public IList<DimensionedQuantityModel> GetDimensionedQuantity_ByType(int typeId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TypeId", typeId);

                return connection.Query<DimensionedQuantityModel>("dbo.spDimensionedQuantities_GetAlLByType", p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public IList<UnitModel> GetUnit_All()
        {
            IList<UnitModel> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<UnitModel>
                    ("dbo.spUnits_GetAll").ToList();
            }
            return output;
        }
    }
}