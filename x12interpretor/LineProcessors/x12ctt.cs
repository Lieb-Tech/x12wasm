
using System.Collections.Generic;
using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public class x12ctt : x12line, Ix12lineProcessor
    {
        public x12ctt() : base("CTT")
        {
            CodeDescription = "CTT - Transaction Totals";
            LineCode = "CTT";
            Fields = new List<x12field>()
            {
                new x12field()
                {
                    Ordinal = 0,
                    FieldName = "CTT - Transaction Totals",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 3,
                    MinLen = 2
                },

                new x12field()
                {
                    Ordinal = 1,
                    FieldName = "Number Of Line Items",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 6,
                    MinLen = 1,
                },
                new x12field()
                {
                    Ordinal = 2,
                    FieldName = "Quantity Hash Total",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 10,
                    MinLen = 1,
                },
            };
        }
    }
}
