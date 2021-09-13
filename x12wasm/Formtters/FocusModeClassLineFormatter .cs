using System.Collections.Generic;
using x12wasm.FieldFormatters;
using x12wasm.Models;

namespace x12wasm.Formtters
{
    public class FocusModeClassLineFormatter : IFormatter, ILineFormatter
    {
        const string classNameFocused_base = "fieldValue fieldFocused-";
        const string classNameDefocused_base = "fieldValue fieldDefocused-";
        public string LineCode { get; set; }
        public List<IFieldFormatter> Formatters { get; set; }

        public FocusModeClassLineFormatter()
        {
            
        }
        public void FormatLine(LineResult result, string mode)
        {
            var classNameFocused = $"{classNameFocused_base}{mode}";
            var classNameDefocused = $"{classNameDefocused_base}{mode}";

            Formatters = new List<IFieldFormatter>();
            Formatters.Add(new ChangeClass("PO1", new int[] { 2, 7, 9 }, classNameFocused, classNameDefocused));
            Formatters.Add(new ChangeClass("ISA", null, classNameFocused, classNameDefocused));
            Formatters.Add(new ChangeClass("GS", null, classNameFocused, classNameDefocused));
            Formatters.Add(new ChangeClass("ST", null, classNameFocused, classNameDefocused));
            Formatters.Add(new ChangeClass("REF", null, classNameFocused, classNameDefocused));
            Formatters.Add(new ChangeClass("CTT", null, classNameFocused, classNameDefocused));
            Formatters.Add(new ChangeClass("N1", new int[1] { 4 }, classNameFocused, classNameDefocused));
            Formatters.Add(new ChangeClass("BEG", new int[1] { 3 }, classNameFocused, classNameDefocused));

            foreach (var formatter in Formatters)
            {
                if (result.FieldResults is null)
                    continue;

                foreach (var r in result.FieldResults)
                {
                    formatter.UpdateField(result, r);
                }

                result.LineSuffix = $"<div class='lineSuffix lineSuffix-{mode}'>{result.OriginalLineSuffix}</div>";
            }
        }
    }
}
