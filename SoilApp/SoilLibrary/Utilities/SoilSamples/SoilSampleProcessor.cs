﻿using SoilLibrary.Models;
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

        private IList<UnitModel> Units { get; set; } = GlobalConfig.Connection.GetUnits_All();

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

            foreach (var sampleRow in RawSamples)
            {
                ProcessSample(sampleRow);
            }
        }

        private void ProcessSample(List<string> sampleRow)
        {
            SoilSampleModel newSampleModel = new SoilSampleModel
            {
                FieldId = Convert.ToInt32(sampleRow[FieldIndex]),
                SampleYear = Convert.ToInt32(sampleRow[YearIndex])
            };

            foreach (var key in NutrientMappings.Keys)
            {
                SoilSampleNutrientModel newNutrientRecord = CreateSampleNutrientRecord(sampleRow, newSampleModel, key);
                newSampleModel.Nutrients.Add(newNutrientRecord);
            }
            GlobalConfig.Connection.CreateSoilSample(newSampleModel);
            Samples.Add(newSampleModel);
        }

        private SoilSampleNutrientModel CreateSampleNutrientRecord(List<string> sample, SoilSampleModel newSampleModel, string key)
        {
            int index = NutrientMappings[key];
            SoilSampleNutrientModel newNutrientRecord = new SoilSampleNutrientModel();

            newNutrientRecord.Amount = null;
            newNutrientRecord.Goal = null;

            newNutrientRecord.NutrientId = Convert.ToInt32(key);

            NutrientModel nutrient = GlobalConfig.Connection.GetNutrient_ById(newNutrientRecord.NutrientId);
            

            if (sample[index] != "NULL")
            {
                newNutrientRecord.Amount = Convert.ToDecimal(sample[index]);

                string nutrientUnit = Units.Where<UnitModel>(unit => unit.Id == nutrient.UnitId).Select(unit => unit.Unit).First();

                //Makes sure it's a quantity that needs to be converted
                if (nutrientUnit != "None")
                {
                    newNutrientRecord.Amount *= SoilSampleNutrientModel.PPMConversionFactor;
                }
            }
            
            Regex recommendationRegex = new Regex($"^{key}\\sRec\\s\\d");
            var recommendationColumns = RecommendationMappings
                .Where(pair => recommendationRegex.IsMatch(pair.Key))
                .Select(pair => pair.Value);

            if (recommendationColumns.Count() > 0)
            {
                bool allNull = recommendationColumns.All(i => sample[i] == "NULL");


                decimal totalRec = recommendationColumns
                                            .Where(i => decimal.TryParse(sample[i], out decimal recommendation))
                                            .Select(i => decimal.Parse(sample[i]))
                                            .Sum();

                if (totalRec >= 0 && allNull == false)
                {
                    if (newNutrientRecord.Amount == null)
                    {
                        // if the nutrient level is null, make the goal just the recommendation
                        newNutrientRecord.Goal = Convert.ToInt32(Math.Round(totalRec, 0));
                    }
                    // Otherwise, the goal is the current level plus the total recommendation
                    else
                    {
                        newNutrientRecord.Goal = Convert.ToInt32(
                        Math.Round(
                            (double)(totalRec + newNutrientRecord.Amount), 0));
                    }
                }
            }

            return newNutrientRecord;
        }
    }
}
