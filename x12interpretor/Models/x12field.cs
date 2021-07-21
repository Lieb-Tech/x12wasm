using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x12interpretor.Models
{
    public class x12field
    {
        public string FieldCode { get; set; }
        public int Ordinal { get; set; }
        public string FieldName { get; set; }
        public bool IsRequired { get; set; }
        public x12fieldFormat Format { get; set; }

        public int MinLen { get; set; }
        public int MaxLen { get; set; }

        public Dictionary<string, string> ValueMap {get; set;}

        public x12field()
        {
            ValueMap = new Dictionary<string, string>();
        }
    }
}
