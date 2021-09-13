using x12wasm.Models;

namespace x12wasm.Formtters
{
    public interface IFileFormatter
    {
        void FormatFile(FileResult file);
    }
}
