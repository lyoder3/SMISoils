using Dapper;
using SoilLibrary.Models;
using System;
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
        public void CreateNutrient(NutrientModel model)
        {
            var p = new DynamicParameters();
            p.Add("@QuantityName", model.ItemName);
            p.Add("@UnitId", model.UnitId);
            p.Add("@id", model.Id, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Execute("dbo.spNutrients_Insert", p, commandType: CommandType.StoredProcedure);
            }
            model.Id = p.Get<int>("@id");
        }
        public void CreateProduct(ProductModel model)
        {
            var p = new DynamicParameters();
            p.Add("@QuantityName", model.ItemName);
            p.Add("@UnitId", model.UnitId);
            p.Add("@id", model.Id, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Execute("dbo.spProducts_Insert", p, commandType: CommandType.StoredProcedure);
            }
            model.Id = p.Get<int>("@id");
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

        public void CreateSampleNutrients_Batch(IList<SoilSampleNutrientModel> models)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Execute("dbo.spSoilSamplesNutrients_Insert", models, commandType: CommandType.StoredProcedure);
            }
            FieldsNutrients_Upsert(models);
        }

        private void FieldsNutrients_Upsert (IList<SoilSampleNutrientModel> models)
        {
            // This works because the list of models passed is never empty and they are always for one soil sample object
            int sampleId = models[0].SoilSampleId;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var param = new DynamicParameters();
                param.Add("@SoilSampleId", sampleId);
                param.Add("@FieldId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                param.Add("@SampleYear", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection
                    .Execute("dbo.spSoilSamplesNutrients_GetFieldIdAndSampleYear", param, commandType: CommandType.StoredProcedure);
                int fieldId = param.Get<int>("@FieldId");
                int sampleYear = param.Get<int>("@SampleYear");

                foreach (SoilSampleNutrientModel model in models)
                {
                    var p = new DynamicParameters();
                    p.Add("@FieldId", fieldId);
                    p.Add("@NutrientId", model.NutrientId);
                    p.Add("@Amount", model.Amount);
                    p.Add("@Goal", model.Goal);
                    p.Add("@SampleYear", sampleYear);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.spFieldsNutrients_Upsert", p, commandType: CommandType.StoredProcedure);
                }
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
        public IList<UnitModel> GetUnits_All()
        {
            IList<UnitModel> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<UnitModel>
                    ("dbo.spUnits_GetAll").ToList();
            }
            return output;
        }

        public IList<ProductModel> GetProducts_All()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<ProductModel>
                    ("dbo.spProducts_GetAll").ToList();
            }
        }

        public IList<NutrientModel> GetNutrients_All()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<NutrientModel>
                    ("dbo.spNutrients_GetAll").ToList();
            }
        }
    }
}