using SoilLibrary.DataAccess;
using SoilLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Utilities
{
    public class SoilSampleData
    {
        public SoilSampleModel Sample { get; set; }
        private IDataConnection Connection { get; set; } = GlobalConfig.Connection;


        public void WriteSoilSample()
        {
            Connection.CreateSoilSample(Sample);

            foreach (SoilSampleNutrientModel ssn in Sample.Nutrients)
            {
                var currentModel = Connection.GetFieldNutrient_ByIds(Sample.FieldId, ssn.NutrientId);

                if (currentModel != null)
                {
                    if (ssn.Amount == null)
                    {
                        ssn.SoilSampleId = Sample.Id;
                        ssn.Amount = currentModel.Amount;
                        Connection.CreateSoilSampleNutrient(ssn);
                        Connection.CreateFieldNutrient(ssn, Sample.FieldId, Sample.Id);
                    }
                }
                else
                {
                    Connection.CreateFieldNutrient(ssn, Sample.FieldId, Sample.Id);
                }
            }
        }
    }
}
