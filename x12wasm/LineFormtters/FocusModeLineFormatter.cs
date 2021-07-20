using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x12interpretor.Models;
using x12wasm.FieldFormatters;

namespace x12wasm.LineFormtters
{
    public class FocusModeLineFormatter 
    {
        public string LineCode { get; set; }
        public List<IFieldFormatter> Formatters { get; set; }

        public FocusModeLineFormatter()
        {
            Formatters = new List<IFieldFormatter>();
            Formatters.Add(new MakeItLightBlue("PO1", new int[] { 2, 7, 9 }));
            Formatters.Add(new MakeItLightBlue("ISA", null));
            Formatters.Add(new MakeItLightBlue("GS", null));
            Formatters.Add(new MakeItLightBlue("ST", null));
            Formatters.Add(new MakeItLightBlue("REF", null));
            Formatters.Add(new MakeItLightBlue("CTT", null));

            Formatters.Add(new MakeItLightBlue("N1", new int[1] { 4 }));
            Formatters.Add(new MakeItLightBlue("BEG", new int[1] { 3 }));
        }
        public void FormatLine(x12lineResult result)
        {
            foreach (var formatter in Formatters)
            {
                if (result.FieldResults is null)
                    continue;

                foreach (var r in result.FieldResults)
                {
                    formatter.UpdateField(result, r);
                }
            }
        }
    }
}
