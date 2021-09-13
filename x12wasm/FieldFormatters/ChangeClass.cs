using System;
using System.Linq;
using x12wasm.Models;

namespace x12wasm.FieldFormatters
{
    public class ChangeClass : IFieldFormatter
    {
        private readonly int[] _ordinalsToSkip;
        private readonly string _code;
        private readonly string _focusedClass;
        private readonly string _defocusedClass;

        public ChangeClass(string lineCode, int[] ordinalsToSkip, string focusedClass, string defocusedClass)
        {
            _focusedClass = focusedClass;
            _defocusedClass = defocusedClass;
            _code = lineCode;
            _ordinalsToSkip = ordinalsToSkip ?? new int[0];
        }
        public void UpdateField(LineResult lineResult, FieldResult fieldResult)
        {
            if (lineResult.LineCode != _code)
                return;

            if (!_ordinalsToSkip.Contains(fieldResult.Field.Ordinal))
                fieldResult.DisplayValue = $"<div class='{_defocusedClass}'>{fieldResult.FileValue}</div>";
            else
                fieldResult.DisplayValue = $"<div class='{_focusedClass}'>{fieldResult.FileValue}</div>";
        }
    }
}
