using x12interpretor.Models;

namespace x12wasm.Formtters
{
    public class DefaultLineFormatter: IFormatter, ILineFormatter
    {
        public void FormatLine(x12lineResult result)
        {
            if (result.FieldResults is null)
                return;

            foreach (var r in result.FieldResults)
            {
                r.DisplayValue = r.FileValue;
            }
        }
    }
}
