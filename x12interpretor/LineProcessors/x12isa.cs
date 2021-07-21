using System.Collections.Generic;
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
                    Ordinal = 0,
                    FieldName = "ISA - Interchage Control Header",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 3,
                    MinLen = 2
                },
                new x12field()
                {
                    FieldCode = "ISA01",
                    Ordinal = 1,
                    FieldName = "Authorization Information Qualifier",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "00", "No Authorization Information Present" }
                    }
                },
                new x12field()
                {
                    FieldCode = "ISA02",
                    Ordinal = 2,
                    FieldName = "Authorization Information",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 10,
                    MinLen = 2
                },
                new x12field()
                {
                    FieldCode = "ISA03",
                    Ordinal = 3,
                    FieldName = "Security Information Qualifier",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "00", "No Security Information Present" }
                    }
                },
                new x12field()
                {
                    FieldCode = "ISA04",
                    Ordinal = 4,
                    FieldName = "Security Information",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 10,
                    MinLen = 2
                },
                new x12field()
                {
                    FieldCode = "ISA05",
                    Ordinal = 5,
                    FieldName = "Interchange ID Qualifier",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen =2,
                    ValueMap = new Dictionary<string, string> ()
                    {
                        { "01", "Duns (Dun & Bradstreet)" },
                        { "02", "SCAC (Standard Carrier Alpha Code)" },
                        { "ZZ" , "Mutually Defined" }
                    }
                },
                new x12field()
                {
                    FieldCode = "ISA06",
                    Ordinal = 6,
                    FieldName = "Interchange Sender ID",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 15,
                    MinLen = 2
                },
                new x12field()
                {
                    FieldCode = "ISA07",
                    Ordinal = 7,
                    FieldName = "Interchange ID Qualifier",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "01", "Duns (Dun & Bradstreet)" },
                        { "08", "UCC EDI Comm. ID" },
                        { "12", "Phone Number" },
                        {  "ZZ", "Mutually Defined" }
                    }
                },
                new x12field()
                {
                    FieldCode = "ISA08",
                    Ordinal = 8,
                    FieldName = "Interchange Reciever ID",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2 
                },
                new x12field()
                {
                    FieldCode = "ISA09",
                    Ordinal = 9,
                    FieldName = "Interchange Date ",
                    Format = x12fieldFormat.Date6,
                    IsRequired = true,
                    MaxLen = 6,
                    MinLen = 6
                },
                new x12field()
                {
                    FieldCode = "ISA10",
                    Ordinal = 10,
                    FieldName = "Interchange Time - HHMM",
                    Format = x12fieldFormat.Time,
                    IsRequired = true,
                    MaxLen = 4,
                    MinLen = 4
                },
                new x12field()
                {
                    FieldCode = "ISA11",
                    Ordinal = 11,
                    FieldName = "Interchange Control Standards",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 1,
                    MinLen = 1,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "U", "U.S. EDI Community of ASC X12" }
                    }
                },
                new x12field()
                {
                    FieldCode = "ISA12",
                    Ordinal = 12,
                    FieldName = "Interchange Control Version Number",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 5,
                    MinLen = 5,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "00401", "Draft Standards for Trial Use Approved for Publication by ASC X12 Procedures Review Board through October 1997" }
                    }
                },
                new x12field()
                {
                    FieldCode = "ISA13",
                    Ordinal = 13,
                    FieldName = "Interchange Control Number",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 9,
                    MinLen = 1
                },
                new x12field()
                {
                    FieldCode = "ISA14",
                    Ordinal = 14,
                    FieldName = "Acknowledgement Requested",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 1 ,
                    MinLen = 1,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "0", "No Acknowledgment Requested" }
                    }
                },
                new x12field()
                {
                    FieldCode = "ISA15",
                    Ordinal = 15,
                    FieldName = "Usage Indicator",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 1 ,
                    MinLen = 1,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "P", "Production Data" },
                        { "T", "test for DEV / STAGE" }
                    }
                },
                new x12field()
                {
                    FieldCode = "ISA16",
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
