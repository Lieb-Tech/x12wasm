using x12interpretor.Models;

namespace x12wasm.FieldFormatters
{
    public class NDC : IFieldFormatter
    {
        public void UpdateField(x12lineResult lineResult,  x12fieldResult fieldResult)
        {
            if (lineResult.LineCode == "PO1" && (fieldResult.Field.Ordinal == 7 || fieldResult.Field.Ordinal == 9) && fieldResult.FileValue.Length > 10)
                fieldResult.FileValue = $"<b>{fieldResult.FileValue}</b>";
        }
    }
}

