using x12interpretor.Models;

namespace x12wasm.Formtters
{
    public interface IFileFormatter
    {
        void FormatFile(x12fileResult file);
    }
}
