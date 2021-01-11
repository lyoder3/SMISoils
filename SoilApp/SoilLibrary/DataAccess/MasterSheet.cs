using SoilLibrary.Models;
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

        private IMasterSheetProcessor _processor;

        public IMasterSheetProcessor Processor
        {
            get { return _processor; }
            set { _processor = value; }
        }

        private static readonly string SpreadsheetId = "1AUMOHvJnfGT5Ve1Ep-ECslC9bhj8sP0DAI64CmQ-iWw";


        private static readonly string SheetRange = "'Master Sheet'";

        public MasterSheet(IGoogleSheetConnector googleSheet, IMasterSheetProcessor processor)
        {
            GoogleSheet = googleSheet;
            Processor = processor;
        }

        public void UpsertFieldsAndRotations()
        {
            var rows = GoogleSheet.GetValues(SpreadsheetId, SheetRange);

            IList<IList<object>> idUpdateRows = Processor.Process(rows);

            UpdateFieldIds(idUpdateRows);
        }

        public void UpdateFieldIds(IList<IList<object>> values)
        {
            GoogleSheet.WriteValues(values, SpreadsheetId, "DatabaseIds!A1");
        }
    }
}
