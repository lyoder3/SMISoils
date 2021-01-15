using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoilLibrary.Models;
using SoilLibrary.Utilities;

namespace SoilLibrary.Utilities
{
    public class AnalysesSheetProcessor : GoogleSheetProcessor
    {
        private int IdIndex { get; set; } = 0;
        private int ProductIdIndex { get; set; } = 1;
        public Dictionary<string, int> NutrientMappings { get; set; }

        public AnalysesSheetColumnProcessor ColumnProcessor { get; set; }
        public AnalysesSheetProcessor(IList<IList<object>> rows)
        {
            Rows = rows;
            PopHeaders();
            
            //Conver to list of strings for column processor
            List<string> headers = Headers.Select(i => i.ToString()).ToList();

            ColumnProcessor = new AnalysesSheetColumnProcessor(headers); 
        }
        public override void ProcessRow(IList<object> row)
        {
            bool idExists = int.TryParse((string)row[IdIndex], out int id);

            if (idExists == false)
            {
                id = 0;
            }

            AnalysisModel newAnalysisModel = new AnalysisModel
            {
                Id = id,
                ProductId = Convert.ToInt32(row[ProductIdIndex]),
                Nutrients = new List<AnalysisNutrientModel>()
            };

            foreach (var key in NutrientMappings.Keys)
            {
                AnalysisNutrientModel newNutrientRecord = CreateAnalysisNutrientRecord(row, newAnalysisModel, key);
                newAnalysisModel.Nutrients.Add(newNutrientRecord);
            }
            GlobalConfig.Connection.CreateAnalysis(newAnalysisModel);

            IList<object> updateRow = new object[]
            {
                newAnalysisModel.Id,
            };

            UpdateValues.Add(updateRow);
        }
        private AnalysisNutrientModel CreateAnalysisNutrientRecord(IList<object> sample, AnalysisModel newSampleModel, string key)
        {
            int index = NutrientMappings[key];
            AnalysisNutrientModel newNutrientRecord = new AnalysisNutrientModel();

            newNutrientRecord.Amount = Convert.ToDecimal((string)sample[index]);

            newNutrientRecord.NutrientId = Convert.ToInt32(key);

            return newNutrientRecord;
        }
        public override void ProcessRows()
        {
            ColumnProcessor.MapColumns();

            NutrientMappings = ColumnProcessor.NutrientMappings;

            UpdateValues.Add(new object[] { Headers[0] });

            foreach (var row in Rows)
            {
                ProcessRow(row);
            }
        }
    }
}
