using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public class x12isa : x12line, Ix12lineProcessor
    {
        public x12isa() : base("ISA")
        {
            CodeDescription = "ISA - Interchage Control Header";
            LineCode = "ISA";
            Fields = new List<x12field>()
            {
                new x12field()
                {
                    Ordinal = 1,
                    FieldName = "Authorization Information Qualifier",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2
                },
                new x12field()
                {
                    Ordinal = 2,
                    FieldName = "Authorization Information",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 10,
                    MinLen = 2
                },
                new x12field()
                {
                    Ordinal = 3,
                    FieldName = "Security Information Qualifier",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2
                },
                new x12field()
                {
                    Ordinal = 4,
                    FieldName = "Security Information",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 10,
                    MinLen = 2
                },
                new x12field()
                {
                    Ordinal = 5,
                    FieldName = "Interchange ID Qualifier",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen =2
                },
                new x12field()
                {
                    Ordinal = 6,
                    FieldName = "Interchange Sender ID",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 15,
                    MinLen = 2
                },
                new x12field()
                {
                    Ordinal = 7,
                    FieldName = "Interchange ID Qualifier",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2
                },
                new x12field()
                {
                    Ordinal = 8,
                    FieldName = "Interchange Reciever ID",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2 
                },
                new x12field()
                {
                    Ordinal = 9,
                    FieldName = "Interchange Date ",
                    Format = x12fieldFormat.Date6,
                    IsRequired = true,
                    MaxLen = 6,
                    MinLen = 6
                },
                new x12field()
                {
                    Ordinal = 10,
                    FieldName = "Interchange Time - HHMM",
                    Format = x12fieldFormat.Time,
                    IsRequired = true,
                    MaxLen = 4,
                    MinLen = 4
                },
                new x12field()
                {
                    Ordinal = 11,
                    FieldName = "Interchange Control Standards",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 1,
                    MinLen = 1
                },
                new x12field()
                {
                    Ordinal = 12,
                    FieldName = "Interchange Control Version Number",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 5,
                    MinLen = 5
                },
                new x12field()
                {
                    Ordinal = 13,
                    FieldName = "Interchange Control Number",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 9,
                    MinLen = 1
                },
                new x12field()
                {
                    Ordinal = 14,
                    FieldName = "Acknowledgement Requested",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 1 ,
                    MinLen = 1
                },
                new x12field()
                {
                    Ordinal = 15,
                    FieldName = "Usage Indicator",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 1 ,
                    MinLen = 1
                },
                new x12field()
                {
                    Ordinal = 16,
                    FieldName = "Component Element Separator",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 1,
                    MinLen = 1
                },
            };
        }
      
    }
}
