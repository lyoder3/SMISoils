using System.Collections.Generic;

namespace SoilLibrary.Utilities
{
    public interface ICSVProcessor
    {
        List<List<string>> ReadValues();
    }
}