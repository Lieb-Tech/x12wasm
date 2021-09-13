using System.Linq;
using x12wasm.Models;

namespace x12wasm.Formtters
{
    public class SectionFormatter : IFormatter, IFileFormatter
    {
        private readonly string[] _colors = new string[2] { "section1", "section2" };
        private int _currentColor = -1;
        private readonly string _firstLineCode;
        private readonly string _lastLineCode;

        public SectionFormatter(string firstLineCode, string lastLineCode)
        {
            _firstLineCode = firstLineCode;
            _lastLineCode = lastLineCode;
        }
        public void FormatFile(FileResult file)
        {
            bool inSection = false;
            foreach (var line in file.Lines)
            {
                if (line.FieldResults is null)
                    continue;

                // until all lines are configured -- all should have a 0
                var lineCode = line.FieldResults.FirstOrDefault(z => z.Field.Ordinal == 0);
                if (lineCode is null)
                    continue;

                if (lineCode.FileValue == _firstLineCode || lineCode.FileValue == _lastLineCode)
                {
                    inSection = true;
                    string color = getNextColor();
                    foreach (var field in line.FieldResults)
                    {
                        field.DisplayValue = $"<div class='fieldValue {color}'>{field.FileValue}</div>";
                    }

                    if (lineCode.FileValue == _lastLineCode)
                        inSection = false;
                }                
                else if (inSection)
                {
                    foreach (var field in line.FieldResults)
                    {
                        field.DisplayValue = $"<div class='fieldValue {_colors[_currentColor]}'>{field.FileValue}</div>";
                    }
                }
                else
                {
                    foreach (var field in line.FieldResults)
                    {
                        field.DisplayValue = field.FileValue;
                    }
                }
            }
        }

        private string getNextColor()
        {
            _currentColor++;
            if (_currentColor == _colors.Length)
                _currentColor = 0;

            return _colors[_currentColor];
        }
    }
}
