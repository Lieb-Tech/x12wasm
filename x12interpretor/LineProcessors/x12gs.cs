using System.Collections.Generic;
using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public class x12gs : x12line, Ix12lineProcessor
    {
        public x12gs() : base("GS")
        {
            CodeDescription = "GS - Functional Group Header";
            LineCode = "GS";
            Fields = new List<x12field>()
            {
                new x12field()
                {
                    Ordinal = 0,
                    FieldName = "GS - Functional Group Header",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 3,
                    MinLen = 2
                },
                new x12field()
                {
                    Ordinal = 1,
                    FieldName = "Functional Identifier Code",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2
                },
                new x12field()
                {
                    Ordinal = 2,
                    FieldName = "Application Sender's Code",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,                    
                    MinLen = 2,
                    MaxLen = 15
                },
                new x12field()
                {
                    Ordinal = 3,
                    FieldName = "Application Receivers's Code",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MinLen = 2,
                    MaxLen = 15
                },
                new x12field()
                {
                    Ordinal = 4,
                    FieldName = "Date - CCYYMMDD",
                    Format = x12fieldFormat.Date8,
                    IsRequired = true,
                    MinLen = 8,
                    MaxLen = 8
                },
                new x12field()
                {
                    Ordinal = 5,
                    FieldName = "Time - HHMM or HHMMSS or HHMMSSD or HHMMSSDD",
                    Format = x12fieldFormat.Time,
                    IsRequired = true,
                    MinLen = 4,
                    MaxLen = 8
                },
                new x12field()
                {
                    Ordinal = 6,
                    FieldName = "Group Control Number",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MinLen = 1,
                    MaxLen = 9
                },
                new x12field()
                {
                    Ordinal = 7,
                    FieldName = "Responsible Agency Code",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MinLen = 1,
                    MaxLen = 2
                },
                new x12field()
                {
                    Ordinal = 8,
                    FieldName = "Version / Release / Industry Identifier",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MinLen = 1,
                    MaxLen = 12
                },
            };
        }
    }
}
