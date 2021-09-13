using System.Collections.Generic;
using x12FileParser.Models;

namespace x12wasm.Models
{
    public class FileResult
    {
        public bool Error { get; set; }

        public string FileName { get; set; }
        public List<LineResult> Lines { get; set; } = new List<LineResult>();

        private x12fileResult original;

        public x12fileResult ToX12FileResult() => original;
        public FileResult(x12fileResult fileResult)
        {
            original = fileResult;
            Error = fileResult.Error;
            FileName = fileResult.FileName;
            foreach (var line in fileResult.Lines)
            {
                Lines.Add(new LineResult(line));
            }
        }
    }
}
