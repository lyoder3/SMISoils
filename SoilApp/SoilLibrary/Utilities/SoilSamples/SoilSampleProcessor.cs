using SoilLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoilLibrary.Utilities
{
    public class SoilSampleProcessor : ISoilSampleProcessor
    {
        private SoilSampleColumnProcessor ColumnProcessor { get; set; }
        private int FieldIndex { get; set; }
        private int YearIndex { get; set; }
        private Dictionary<string, int> RecommendationMappings { get; set; }
        private Dictionary<string, int> NutrientMappings { get; set; }
        public List<string> FilePaths { get; set; } = new List<string>();
        public List<List<string>> RawSamples { get; set; }
        public List<SoilSampleModel> Samples { get; set; } = new List<SoilSampleModel>();

        public SoilSampleProcessor(List<string> filePaths)
        {
            foreach (var path in filePaths)
            {
                FilePaths.Add(Path.GetFullPath(path));
            }
        }
        public List<List<string>> ReadValues()
        {
            List<List<string>> allLines = new List<List<string>>();

            foreach (var file in FilePaths)
            {
                List<string> lines = File.ReadAllLines(file).ToList();
                foreach (var line in lines)
                {
                    // Ignore headers on every file except first file
                    if (FilePaths.IndexOf(file) > 0 && lines.IndexOf(line) == 0)
                    {
                        continue;
                    }
                    allLines.Add(line.Split(',').ToList());
                }
            }
            RawSamples = allLines;

            return allLines;
        }
        private void PopHeaders()
        {
            var headers = RawSamples[0];
            RawSamples = RawSamples.GetRange(1, RawSamples.Count-1);

            ColumnProcessor = new SoilSampleColumnProcessor(headers);
        }

        public void ProcessSamples()
        {
            // TODO - Used stored procedure to upsert FieldsNutrients after writing all nutrients
            ReadValues();
            PopHeaders();

            ColumnProcessor.MapColumns();

            NutrientMappings = ColumnProcessor.NutrientMappings;
            RecommendationMappings = ColumnProcessor.RecommendationMappings;
            FieldIndex = ColumnProcessor.FieldIndex;
            YearIndex = ColumnProcessor.YearIndex;

            foreach (var sample in RawSamples)
            {
                ProcessSample(sample);
            }
        }

        private void ProcessSample(List<string> sample)
        {
            SoilSampleModel newSample = new SoilSampleModel
            {
                FieldId = Convert.ToInt32(sample[FieldIndex]),
                SampleYear = Convert.ToInt32(sample[YearIndex])
            };

            GlobalConfig.Connection.CreateSoilSample(newSample);

            foreach (var key in NutrientMappings.Keys)
            {
                SoilSampleNutrientModel newNutrientRecord = new SoilSampleNutrientModel();
                newNutrientRecord.SoilSampleId = newSample.Id;
                decimal currentLevel = Convert.ToDecimal(sample[NutrientMappings[key]]);

                newNutrientRecord.Amount = currentLevel * SoilSampleNutrientModel.PPMConversionFactor;

                Regex recommendationRegex = new Regex($"^{key}\\sRec\\s\\d");
                var recommendationColumns = RecommendationMappings
                    .Where(pair => recommendationRegex.IsMatch(pair.Key))
                    .Select(pair => pair.Value);

                if (recommendationColumns.Count() > 0)
                {
                    decimal totalRec = recommendationColumns.Sum(index => Convert.ToDecimal(sample[index]));
                    newNutrientRecord.NutrientId = Convert.ToInt32(key);
                    
                    newNutrientRecord.Goal = Convert.ToInt32(
                        Math.Round(
                            totalRec + newNutrientRecord.Amount, 0));
                }
                else
                {
                    newNutrientRecord.NutrientId = Convert.ToInt32(key);
                    newNutrientRecord.Goal = 0;
                }
                newSample.Nutrients.Add(newNutrientRecord);
            }
            GlobalConfig.Connection.CreateSoilSample(newSample);
            Samples.Add(newSample);
        }
    }
}
