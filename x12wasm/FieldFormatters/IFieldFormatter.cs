using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x12interpretor.Models;

namespace x12wasm.FieldFormatters
{
    public interface IFieldFormatter
    {
        void UpdateField(x12lineResult lineResult, x12fieldResult fieldResult);
    }
}
