using x12wasm.Models;

namespace x12wasm.Formtters
{
    public interface ILineFormatter
    {
        void FormatLine(LineResult result, string mode);
    }
}
