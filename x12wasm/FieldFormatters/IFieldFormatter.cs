using x12wasm.Models;

namespace x12wasm.FieldFormatters
{
    public interface IFieldFormatter
    {
        void UpdateField(LineResult lineResult, FieldResult fieldResult);
    }
}
