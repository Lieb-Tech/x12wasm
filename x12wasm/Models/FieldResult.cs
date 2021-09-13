using System.Collections.Generic;
using x12FileParser.Models;

namespace x12wasm.Models
{
    public class FieldResult
    {
        public string LineDescription { get; set; }
        public string DisplayValue { get; set; }
        public string FileValue { get; set; }
        public StatusAttributes Status { get; set; }

        public x12field Field { get; set; }
        public Dictionary<string, string> ExtraValues { get; set; }

        public FieldResult(x12fieldResult fieldResult, string lineDesc)
        {
            LineDescription = lineDesc;
            DisplayValue = fieldResult?.FileValue;
            FileValue = fieldResult?.FileValue;
            Status = fieldResult is null ? StatusAttributes.Normal : fieldResult.Status;
            Field = fieldResult?.Field;
            ExtraValues = fieldResult?.ExtraValues;
        }
    }
}