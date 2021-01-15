using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Utilities
{
    public abstract class GoogleSheetProcessor
    {
        public IList<IList<object>> Rows { get; set; }
        public IList<object> Headers { get; set; }

        public IList<IList<object>> UpdateValues { get; set; } = new List<IList<object>>();

        protected IList<object> PopHeaders() 
        {
            var headers = Rows[0];
            Headers = headers;
            Rows = Rows.Skip(1).ToList();

            return headers;
        }
        public abstract void ProcessRow(IList<object> row);
        public abstract void ProcessRows();
    }
}
