
using x12interpretor.Models;

namespace x12wasm.Formtters
{
    public interface ILineFormatter
    {
        void FormatLine(x12lineResult result);
    }
}
