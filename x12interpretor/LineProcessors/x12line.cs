using System.Collections.Generic;
using System.Linq;
using x12interpretor.LinePostProcessors;
using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public class x12line
    {
        public x12line(string lineCode)
        {
            LineCode = lineCode;
            PostProcessors = new List<Ix12linePostProcessor>();
        }

        public List<Ix12linePostProcessor> PostProcessors { get; set; }

        public string LineCode { get; set; }
        public string CodeDescription { get; set; }

        protected List<x12field> Fields { get; set; }

        public x12lineResult ProcessLine(string line)
        {
            var parts = getLineParts(line);
            return new x12lineResult()
            {
                LineCode = this.LineCode,
                OriginalValue = line,
                FieldResults = processParts(parts)
            };
        }

        List<x12fieldResult> processParts(string[] parts)
        {
            var results = new List<x12fieldResult>();
            foreach (var field in Fields.OrderBy(z => z.Ordinal))
            {
                if (field.Ordinal >= parts.Length)
                    continue;

                results.Add(new x12fieldResult()
                {
                    Field = field,
                    FileValue = string.IsNullOrWhiteSpace(parts[field.Ordinal]) ? null : parts[field.Ordinal],
                    DisplayValue = string.IsNullOrWhiteSpace(parts[field.Ordinal]) ? null : parts[field.Ordinal]
                });
            }

            return results;
        }

        string[] getLineParts(string line)
        {
            return line.Substring(0, line.Length - 1).Split('*');
        }
    }
}
