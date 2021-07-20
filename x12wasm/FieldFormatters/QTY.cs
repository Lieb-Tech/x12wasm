
using x12interpretor.Models;

namespace x12wasm.FieldFormatters
{
    public class QTY : IFieldFormatter
    {
        public void UpdateField(x12lineResult lineResult, x12fieldResult fieldResult)
        {
            if (lineResult.LineCode == "PO1" && fieldResult.Field.Ordinal == 2)
                fieldResult.FileValue = $"<b>{fieldResult.FileValue}</b>";
        }
    }
}
