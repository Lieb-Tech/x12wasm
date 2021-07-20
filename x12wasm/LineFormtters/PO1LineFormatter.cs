using System.Collections.Generic;
using x12interpretor.Models;
using x12wasm.FieldFormatters;

namespace x12wasm.LineFormtters
{
    public class PO1LineFormatter
    {
        public string LineCode { get; set; }
        public List<IFieldFormatter> Formatters { get; set; }

        public PO1LineFormatter()
        {
            Formatters = new List<IFieldFormatter>();
            Formatters.Add(new MakeItLightBlue("PO1", new int[] { 2, 7, 9 }));            
        }
        public void FormatLine(x12lineResult result)
        {
            foreach (var formatter in Formatters)
            {
                foreach (var r in result.FieldResults)
                {
                     formatter.UpdateField(result, r);
                }
            }
        }
    }
}
