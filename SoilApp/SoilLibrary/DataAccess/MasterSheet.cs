﻿using SoilLibrary.Models;
using SoilLibrary.Utilities;
using System.Collections.Generic;
using System;


namespace SoilLibrary.DataAccess
{
    public class MasterSheet : IMasterSheet 
    {
        // TODO - Use AutoFac to inject these dependencies
        private IGoogleSheetConnector _googleSheet;

        public IGoogleSheetConnector GoogleSheet
        {
            get { return _googleSheet; }
            set { _googleSheet = value; }
        }

        private static readonly string SpreadsheetId = GlobalConfig.CnnString("MasterSheetTest");

        private static readonly string MasterSheetRange = "Master Sheet";
        private static readonly string ProductsSheetRange = "Products!A:D";
        private static readonly string UnitsSheetRange = "Units!A:B";
        private static readonly string NutrientsSheetRange = "Nutrients!A:D";
        private static readonly string AnalysisSheetRange = "Analysis";
        private static readonly string FieldNutrientSheetRange = "FieldNutrients";

        public MasterSheet()
        {
            GoogleSheet = new GoogleSheetConnector();
        }

        public void Update(MasterSheetTab sheetTab)
        {
            switch (sheetTab)
            {
                case MasterSheetTab.MASTER:
                    UpsertFieldsAndRotations();
                    break;
                case MasterSheetTab.UNITS:
                    UpsertUnits();
                    break;
                case MasterSheetTab.NUTRIENTS:
                    UpsertNutrients();
                    break;
                case MasterSheetTab.PRODUCTS:
                    UpsertProducts();
                    break;
                case MasterSheetTab.ANALYSES:
                    UpsertAnalyses();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void UpsertAnalyses()
        {
            var rows = GoogleSheet.GetValues(SpreadsheetId, AnalysisSheetRange);

            GoogleSheetProcessor processor = new AnalysesSheetProcessor(rows);

            processor.ProcessRows();

            GoogleSheet.WriteValues(processor.UpdateValues, SpreadsheetId, "Analysis!A1");
        }
        private void UpsertProducts()
        {
            var rows = GoogleSheet.GetValues(SpreadsheetId, ProductsSheetRange);

            GoogleSheetProcessor processor = new ProductsSheetProcessor(rows);

            processor.ProcessRows();

            GoogleSheet.WriteValues(processor.UpdateValues, SpreadsheetId, ProductsSheetRange);
        }

        private void UpsertNutrients()
        {
            var rows = GoogleSheet.GetValues(SpreadsheetId, NutrientsSheetRange);

            GoogleSheetProcessor processor = new NutrientsSheetProcessor(rows);

            processor.ProcessRows();

            GoogleSheet.WriteValues(processor.UpdateValues, SpreadsheetId, NutrientsSheetRange);
        }

        public void UpsertFieldsAndRotations()
        {
            var rows = GoogleSheet.GetValues(SpreadsheetId, MasterSheetRange);

            GoogleSheetProcessor processor = new MasterSheetProcessor(rows);

            processor.ProcessRows();

            GoogleSheet.WriteValues(processor.UpdateValues, SpreadsheetId, "FieldIds!A:C");
        }

        public void UpsertUnits()
        {
            var rows = GoogleSheet.GetValues(SpreadsheetId, UnitsSheetRange);

            GoogleSheetProcessor processor = new UnitsSheetProcessor(rows);

            processor.ProcessRows();

            GoogleSheet.WriteValues(processor.UpdateValues, SpreadsheetId, UnitsSheetRange);
        }

        public void WriteNutrientLevels()
        {
            IList<FieldNutrientOutputModel> data = GlobalConfig.Connection.GetFieldNutrients_All();

            IList<IList<object>> writeValues = new List<IList<object>>();
            string[] headers = new string[] { "Farm", "Field", "Acreage", "Nutrient","Soil Sample Level (lbm/ac)", "Current Level (lbm/ac)", "Goal (lbm/ac)", "Last Sampled",
            "Next Crop"};

            writeValues.Add(headers);

            foreach (var row in data)
            {
                object[] outputRow = new object[]
                {
                    row.Farm,
                    row.Field,
                    row.Acreage,
                    row.Nutrient,
                    row.SoilSampleAmount,
                    row.Amount,
                    row.Goal,
                    row.LastSampledYear,
                    row.NextCrop
                };
                writeValues.Add(outputRow);
            }

            GoogleSheet.WriteValues(writeValues, SpreadsheetId, FieldNutrientSheetRange);
        }
    }
}
