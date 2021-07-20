using System.Collections.Generic;

namespace x12interpretor.Models
{
    public class x12fieldResult
    {
        public string FileValue { get; set; }

        public string DisplayValue { get; set; }

        public x12field Field { get; set; }
        public Dictionary<string, string> ExtraValues { get; set; }
    }
}