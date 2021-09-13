using System.Collections.Generic;
using x12FileParser.Models;

namespace x12wasm.Models
{
    public class LineResult
    {
        public string LineCode { get; set; }
        public string LineDescription { get; set; }
        public int OriginalLineNumber { get; set; }
        public string OriginalValue { get; set; }
        
        public string LineSuffix { get; set; }
        public string OriginalLineSuffix { get; set; }
        public List<FieldResult> FieldResults { get; set; } = new List<FieldResult>();

        public LineResult(x12lineResult lineResult)
        {
            LineCode = lineResult.LineCode;
            LineDescription = lineResult.LineDescription;
            OriginalLineNumber = lineResult.OriginalLineNumber;
            OriginalValue = lineResult.OriginalValue;
            LineSuffix = lineResult.LineSuffix;
            OriginalLineSuffix = lineResult.LineSuffix;

            if (lineResult.FieldResults is null)
                return;

            foreach (var fieldResult in lineResult.FieldResults)
            {
                FieldResults.Add(new FieldResult(fieldResult, LineDescription));
            }
            
        }
    }
}
