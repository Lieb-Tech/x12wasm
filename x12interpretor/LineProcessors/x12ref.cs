
using System.Collections.Generic;
using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public class x12ref : x12line, Ix12lineProcessor
    {
        public x12ref() : base("REF")
        {
            CodeDescription = "REF - Reference Idenification";
            LineCode = "REF";
            Fields = new List<x12field>()
            {
                new x12field()
                {
                    Ordinal = 0,
                    FieldName = "REF - Reference Idenification",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 3,
                    MinLen = 2
                },

                new x12field()
                {
                    Ordinal = 1,
                    FieldName = "Reference Identifier Code",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 2,
                    ValueMap = new Dictionary<string, string>()
                    {
                        {  "12", "Billing Account" },
                        {  "AY", "Floor Plan Approval Number" },
                        {  "CO", "Customer Order Number" },
                        {  "CR", "Customer Reference Number" },
                        {  "EU", "End User's Purchase Order Number" },
                        {  "QK", "Sales Program Number" },
                        {  "SU", "Special Processing Code" },
                        {  "CT", "Contract Number" },
                        {  "DP", "Department" },
                        { "7I", "Subscriber Authorization Number" },
                        { "PD" , "Promotion/Deal Number" }
                    }
                },
                new x12field()
                {
                    Ordinal = 2,
                    FieldName = "Refence Identifier",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 30,
                    MinLen = 1,
                    ValueMap = new Dictionary<string, string>()
                    {
                        {  "PAS", "State and Local" },
                        {  "PAF", "Federal" },
                        {  "EDK", "K-12" },
                        {  "EDH", "Higher Education" },
                        // {  "When REF01 =SU the following are valid code for REF02
                        {  "ZSAS", "Signature Required and Saturday Delivery" },
                        {  "ZSIG", "Signature Required" },
                        {  "ZSAT", "Saturday Delivery only" },
                        {  "ZSPC", "Freight Hold" },
                        {  "ZVAS", "no Freight Hold" }                     
                    }
                },                
                new x12field()
                {
                    Ordinal = 3,
                    FieldName = "Description",
                    Format = x12fieldFormat.AlphaNumeric,
                    IsRequired = true,
                    MaxLen = 80,
                    MinLen = 1
                },
            };
        }    
    }
}
