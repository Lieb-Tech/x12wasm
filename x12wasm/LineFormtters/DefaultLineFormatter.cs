using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using x12interpretor.Models;

namespace x12wasm.LineFormtters
{
    public class DefaultLineFormatter
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
