using x12wasm.Models;

namespace x12wasm.Formtters
{
    public class DefaultLineFormatter: IFormatter, ILineFormatter
    {
        public void FormatLine(LineResult result, string mode)
        {
            if (result.FieldResults is null)
                return;

            foreach (var r in result.FieldResults)
            {
                r.DisplayValue = $"<div class='fieldValue fieldDefault-{mode}'>{r.FileValue}</div>";
            }

            result.LineSuffix = $"<div class='lineSuffix lineSuffix-{mode}'>{result.OriginalLineSuffix}</div>";
        }
    }
}
