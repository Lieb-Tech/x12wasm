using System.Collections.Generic;
using x12interpretor.Models;
using x12wasm.FieldFormatters;

namespace x12wasm.Formtters
{
    public class FocusModeLineFormatter : IFormatter, ILineFormatter
    {
        const string newColor = "silver";
        public string LineCode { get; set; }
        public List<IFieldFormatter> Formatters { get; set; }

        public FocusModeLineFormatter()
        {
            Formatters = new List<IFieldFormatter>();
            Formatters.Add(new ChangeColor("PO1", new int[] { 2, 7, 9 }, newColor));
            Formatters.Add(new ChangeColor("ISA", null, newColor));
            Formatters.Add(new ChangeColor("GS", null, newColor));
            Formatters.Add(new ChangeColor("ST", null, newColor));
            Formatters.Add(new ChangeColor("REF", null, newColor));
            Formatters.Add(new ChangeColor("CTT", null, newColor));

            Formatters.Add(new ChangeColor("N1", new int[1] { 4 }, newColor));
            Formatters.Add(new ChangeColor("BEG", new int[1] { 3 }, newColor));
        }
        public void FormatLine(x12lineResult result, string mode)
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
