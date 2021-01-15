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
        private const string db = "SoilTest";

        public void CreateAnalysis(AnalysisModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ProductId", model.ProductId);
                p.Add("@id", model.Id, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

                try
                {
                    connection.Execute("dbo.spAnalyses_Insert", p, commandType: CommandType.StoredProcedure);
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.HelpLink, new Exception(ex.Message));
                }

                model.Id = p.Get<int>("@id");

                foreach (AnalysisNutrientModel an in model.Nutrients)
                {
                    p = new DynamicParameters();
                    p.Add("@AnalysisId", model.Id);
                    p.Add("@NutrientId", an.NutrientId);
                    p.Add("@Amount", an.Amount);

                    connection.Execute("dbo.spAnalysisNutrients_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }

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
                foreach (RotationModel r in model.Rotations)
                {
                    r.FieldId = model.Id;
                }
                connection.Execute("dbo.spRotations_Upsert", model.Rotations, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateOperation(OperationModel model)
        {
            throw new System.NotImplementedException();
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

                foreach (SoilSampleNutrientModel ssn in model.Nutrients)
                {
                    p = new DynamicParameters();
                    p.Add("@SoilSampleId", model.Id);
                    p.Add("@NutrientId", ssn.NutrientId);
                    p.Add("@Amount", ssn.Amount);
                    p.Add("@Goal", ssn.Goal);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spSoilSamplesNutrients_Insert", p, commandType: CommandType.StoredProcedure);

                    p = new DynamicParameters();
                    p.Add("@FieldId", model.FieldId);
                    p.Add("@NutrientId", ssn.NutrientId);
                    p.Add("@Amount", ssn.Amount);
                    p.Add("@Goal", ssn.Goal);
                    p.Add("@SampleYear", model.SampleYear);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spFieldsNutrients_Upsert", p, commandType: CommandType.StoredProcedure);

                }

            }
        }

        public void CreateUnit(UnitModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Unit", model.Unit);
                p.Add("@id", model.Id, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);

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

        public IList<AnalysisModel> GetAnalyses_ByProductId(int productId)
        {
            IList<AnalysisModel> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                if (productId > 0)
                {
                    p.Add("@ProductId", productId);
                }

                output = connection
                    .Query<AnalysisModel>("spAnalyses_GetByProductId", p, commandType: CommandType.StoredProcedure)
                    .ToList();

            }

            return output;
        }

        public UnitModel GetUnit_ById(int unitId)
        {
            UnitModel output = new UnitModel();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                if (unitId > 0)
                {
                    p.Add("@UnitId", unitId);

                    output = connection
                        .Query<UnitModel>("spUnits_GetById", p, commandType: CommandType.StoredProcedure).First();
                }


            }

            return output;
        }
        public NutrientModel GetNutrient_ById(int nutrientId)
        {
            NutrientModel output = new NutrientModel();

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                if (nutrientId > 0)
                {
                    p.Add("@NutrientId", nutrientId);

                    output = connection
                        .Query<NutrientModel>("spNutrients_GetById", p, commandType: CommandType.StoredProcedure).First();
                }
            }
            return output;
        }

        public IList<FieldModel> GetFields(string farmName)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                if (farmName == "ALL")
                {
                    return connection.Query<FieldModel>("spFields_GetAll", commandType: CommandType.StoredProcedure).ToList();
                }
                else
                {
                    var p = new DynamicParameters();
                    p.Add("@FarmName", farmName);
                    return connection.Query<FieldModel>("spFields_GetByFarm", p, commandType: CommandType.StoredProcedure).ToList();
                }

            }
        }

        public IList<int> GetRotationYears()
        {
            IList<int> output = new List<int>();
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@OldestYear", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@NewestYear", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spRotations_GetYearRange", commandType: CommandType.StoredProcedure);

                output.Add(p.Get<int>("@OldestYear"));
                output.Add(p.Get<int>("@NewestYear"));
            }

            return output;
        }

        public IList<FilteredFieldNutrientModel> GetFieldsNutrients_Filter(string farmName,
                                            int rotationYear, int nutrientId, int productId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                if (farmName != "ALL")
                {
                    p.Add("@Farm", farmName);
                }
                p.Add("@RotationYear", rotationYear);
                p.Add("@NutrientId", nutrientId);
                p.Add("@CropId", productId);

                return connection.Query<FilteredFieldNutrientModel>
                    ("spFieldsNutrients_Filter", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public IList<SoilSampleIntentionsModel> GetSoilSampleIntentions(int lastSampled, int rotationYear, int productId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@RotationYear", rotationYear);
                p.Add("@LastSampledYear", lastSampled);
                p.Add("@CropId", productId);

                return connection.Query<SoilSampleIntentionsModel>
                    ("spRotationsSoilSamples_GenerateUpcomingIntentions", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
   
}