
using System.Collections.Generic;
using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public class x12beg : x12line, Ix12lineProcessor
    {
        public x12beg() : base("BEG")
        {
            CodeDescription = "BEG - Transactioal beginning Segment for Purchase Order";
            LineCode = "BEG";
            Fields = new List<x12field>()
            {
                new x12field()
                {
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
                    Ordinal = 2,
                    FieldName = "Purchase Order Type Code",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "NE", "New Order" }      
                    }
                },
                new x12field()
                {
                    Ordinal = 3,
                    FieldName = "Purchase Order Number",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 22,
                    MinLen = 1,                   
                },
                new x12field()
                {
                    Ordinal = 4,
                    FieldName = "Release Number",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = false,
                    MaxLen = 30,
                    MinLen = 1,
                },
                new x12field()
                {
                    Ordinal = 5,
                    FieldName = "Date - CCYYMMDD",
                    Format = x12fieldFormat.Date8,
                    IsRequired = true,
                    MaxLen = 8,
                    MinLen = 1,
                },
                new x12field()
                {
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
