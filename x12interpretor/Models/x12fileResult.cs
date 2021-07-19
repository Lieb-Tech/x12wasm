using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x12interpretor.Models
{
    public class x12fileResult
    {
        public bool Error { get; set; }
        public List<x12lineResult> Lines { get; set; }

        public x12fileResult()
        {
            Lines = new List<x12lineResult>();
        }
     }
}
