using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public class x12n1 : x12line, Ix12lineProcessor
    {
        public x12n1() : base("N1")
        {
            CodeDescription = "N1 - Name";
            LineCode = "N1";
            Fields = new List<x12field>()
            {
                new x12field()
                {
                    Ordinal = 0,
                    FieldName = "N1 - Name",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 3,
                    MinLen = 2
                },

                new x12field()
                {
                    FieldCode = "N101",
                    Ordinal = 1,
                    FieldName = "Entity Identifier Code",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 3,
                    MinLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "SF", "Ship From" },
                        { "BY", "Buying Party (Purchaser)" },
                        { "PO", "Party to Receive Invoice for Goods or Services" },
                        { "BT", "Bill-to-Party" },
                        { "RU", "Resale Dealer" },
                        { "ST", "Ship To" },
                        { "RI", "Remit To" },
                        { "CA", "Carrier" },
                        { "DU", "Reseller" },
                        { "EN", "End User" },
                        { "II", "Issuer of Invoice" },
                        { "PR", "Payer" },
                        { "SE", "Selling Party" },
                        { "SO", "Sold To If Different From Bill To" },
                    }
                },
                new x12field()
                {
                    FieldCode = "N102",
                    Ordinal = 2,
                    FieldName = "Name",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 60,
                    MinLen = 1,
                },
                new x12field()
                {
                    FieldCode = "N103",
                    Ordinal = 3,
                    FieldName = "Identification Code Qualifier",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 3,
                    MinLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        { "91", "Assigned by Seller or Seller's Agent" },
                        { "92", "Assigned by Buyer or Buyer's Agent" }
                    }
                },
                new x12field()
                {
                    FieldCode = "N104",
                    Ordinal = 4,
                    FieldName = "Identification Code Qualifier",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 80,
                    MinLen = 2
                }
            };
        }
    }
}
