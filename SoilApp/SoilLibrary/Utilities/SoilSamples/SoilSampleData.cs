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
                ssn.Goal = null;
                if (ssn.Amount == null)
                {
                    continue;
                }
                else
                {
                    if (ssn.Recommendation != null)
                    {
                        ssn.Goal = Convert.ToInt32(ssn.Recommendation + ssn.Amount);
                    }
                    ssn.SoilSampleId = Sample.Id;
                    Connection.CreateSoilSampleNutrient(ssn);
                    Connection.CreateFieldNutrient(ssn, Sample.FieldId, Sample.SampleYear);
                }
            }
        }
    }
}
