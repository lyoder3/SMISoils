using SoilLibrary.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.Linq;

namespace SoilLibrary.Utilities
{
    public class MasterSheetProcessor : IMasterSheetProcessor
    {
        // TODO - Rewrite all of these methods
        private List<object> Headers { get; set; }
        private List<List<object>> Rows { get; set; }
        private List<FieldModel> Fields { get; set; } = new List<FieldModel>() { };
        private IDictionary<string, int> RelevantColumns { get; set; }

        private IDictionary<int, int> RotationColumns { get; set; }

        private readonly int ProductTypeId = GlobalConfig.Connection.
    GetDimensionedQuantityTypeId_ByName("Product");

        private readonly List<DimensionedQuantityModel> Crops;

        private readonly Regex FarmNameRegex = new Regex("^Farm");
        private readonly Regex FieldNameRegex = new Regex("^Field");
        private readonly Regex RotationRegex = new Regex("\\d{4} SPRING");
        private readonly Regex IdRegex = new Regex("^id");
        private readonly Regex YearRegex = new Regex("(\\d{4})");

        private List<List<object>> IdUpdateList = new List<List<object>>();

        public MasterSheetProcessor(List<List<object>> rows)
        {
            Rows = rows;
        }
        public IList<IList<object>> Process(IList<IList<object>> rows)
        {
            throw new NotImplementedException();
        }

        public void ProcessRow(IList<object> row)
        {
            throw new NotImplementedException();
        }

        public void BuildFarmName(FieldModel newField, string key, IList<object> row)
        {
            throw new NotImplementedException();
        }

        public void BuildFieldName(FieldModel newField, string key, IList<object> row)
        {
            throw new NotImplementedException();
        }

        public void BuildId(FieldModel newField, string key, IList<object> row)
        {
            throw new NotImplementedException();
        }

        public int ExtractYear(object value)
        {
            throw new NotImplementedException();
        }

        public bool FieldModelColumnsExist()
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, int> GetRelevantColumns(IList<object> headers)
        {
            throw new NotImplementedException();
        }

        public IDictionary<int, int> GetRotationColumns()
        {
            throw new NotImplementedException();
        }

        public bool IsFarmName(object value)
        {
            throw new NotImplementedException();
        }

        public bool IsFieldName(object header)
        {
            throw new NotImplementedException();
        }

        public bool IsId(object header)
        {
            throw new NotImplementedException();
        }

        public bool IsRelevantColumn(object header)
        {
            throw new NotImplementedException();
        }

        public bool IsRotation(object header)
        {
            throw new NotImplementedException();
        }

        public bool ValidField(IList<object> row)
        {
            throw new NotImplementedException();
        }
    }
}
