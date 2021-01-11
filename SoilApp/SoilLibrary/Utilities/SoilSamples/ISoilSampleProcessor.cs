using SoilLibrary.Models;
using System.Collections.Generic;

namespace SoilLibrary.Utilities
{
    public interface ISoilSampleProcessor : ICSVProcessor
    {
        List<string> FilePaths { get; set; }
        List<List<string>> RawSamples { get; set; }
        List<SoilSampleModel> Samples { get; set; }

        void ProcessSamples();
    }
}