using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using x12interpretor.LinePostProcessors;
using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public class x12po1 : x12line, Ix12lineProcessor
    {
        public x12po1() : base("PO1")
        {
            CodeDescription = "PO1 - Baseline Item Data";
            LineCode = "PO1";
            PostProcessors = new List<Ix12linePostProcessor>()
            {
                 new x12po1PostProcessor()
            };
            Fields = new List<x12field>()
            {
                new x12field()
                {
                    Ordinal = 0,
                    FieldName = "PO1 - Baseline Item Data",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 3,
                    MinLen = 2
                },

                new x12field()
                {
                    Ordinal = 1,
                    FieldName = "Element Name",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = false,
                    MaxLen = 20,
                    MinLen = 1,                    
                },
                new x12field()
                {
                    Ordinal = 2,
                    FieldName = "Quantity Ordered",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 15,
                    MinLen = 1,                    
                },
                new x12field()
                {
                    Ordinal = 3,
                    FieldName = "Unit or Basis for Measurement Code",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 3,
                    MinLen = 1,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "EA", "Each" }
                    }
                },
                new x12field()
                {
                    Ordinal = 4,
                    FieldName = "Unit Price",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 17,
                    MinLen = 1
                },
                new x12field()
                {
                    Ordinal = 5,
                    FieldName = "Basis of Unit Price Code",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = false,
                    MinLen = 2,
                    MaxLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "CA", "Catalog" },
                        { "PE", "Price per Each" }
                    }
                },
                new x12field()
                {
                    Ordinal = 6,
                    FieldName = "Basis of Unit Price Code",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = false,
                    MinLen = 2,
                    MaxLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "BP", "Buyer's Part Number" },
                        { "VC", "Vendor's (Seller's) Catalog Number"},
                        { "VN", "Vendor’s Item Number" }
                    }
                },
                new x12field()
                {
                    Ordinal = 7,
                    FieldName = "Product/Service ID",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = false,
                    MinLen = 1,
                    MaxLen = 48
                },
                new x12field()
                {
                    Ordinal = 8,
                    FieldName = "Product/Service ID Qualifier",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MinLen = 2,
                    MaxLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "BP", "Buyer's Part Number" },
                        { "VC", "Vendor's (Seller's) Catalog Number"},
                        { "VN", "Vendor’s Item Number" }
                    }
                },
                new x12field()
                {
                    Ordinal = 9,
                    FieldName = "Product/Service ID",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MinLen = 1,
                    MaxLen = 48
                }
            };
        }
    }
}
