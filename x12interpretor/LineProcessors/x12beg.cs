
using System.Collections.Generic;
using x12interpretor.LinePostProcessors;
using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public class x12beg : x12line, Ix12lineProcessor
    {
        public x12beg() : base("BEG")
        {
            PostProcessors = new List<Ix12linePostProcessor>()
            {
                 new x12bePostProcessor()
            };
            CodeDescription = "BEG - Transactioal beginning Segment for Purchase Order";
            LineCode = "BEG";
            Fields = new List<x12field>()
            {
                new x12field()
                {                    
                    Ordinal = 0,
                    FieldName = "BEG - Transactioal beginning Segment for Purchase Order",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 3,
                    MinLen = 2
                },

                new x12field()
                {
                    FieldCode = "BEG01",
                    Ordinal = 1,
                    FieldName = "Transaction Set Purpose Code",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "00", "Original" }
                    }
                },
                new x12field()
                {
                    FieldCode = "BEG02",
                    Ordinal = 2,
                    FieldName = "Purchase Order Type Code",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "NE", "New Order" },
                        { "SA", "Stand-alone Order" }
                    }
                },
                new x12field()
                {
                    FieldCode = "BEG03",
                    Ordinal = 3,
                    FieldName = "Purchase Order Number",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 22,
                    MinLen = 1,                   
                },
                new x12field()
                {
                    FieldCode = "BEG04",
                    Ordinal = 4,
                    FieldName = "Release Number",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = false,
                    MaxLen = 30,
                    MinLen = 1,
                },
                new x12field()
                {
                    FieldCode = "BEG05",
                    Ordinal = 5,
                    FieldName = "Date - CCYYMMDD",
                    Format = x12fieldFormat.Date8,
                    IsRequired = true,
                    MaxLen = 8,
                    MinLen = 1,
                },
                new x12field()
                {
                    FieldCode = "BEG06",
                    Ordinal = 6,
                    FieldName = "Contract Number",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = false,
                    MaxLen = 30,
                    MinLen = 1,
                },
            };
        }
    }
}
