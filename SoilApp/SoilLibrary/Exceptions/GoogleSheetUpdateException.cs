using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoilLibrary.Exceptions
{
    public class GoogleSheetUpdateException : Exception
    {
        public GoogleSheetUpdateException()
        {

        }

        public GoogleSheetUpdateException(string message) : base(message)
        {

        }
    }
}
