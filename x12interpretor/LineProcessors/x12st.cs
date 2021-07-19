﻿using System.Collections.Generic;
using x12interpretor.Models;

namespace x12interpretor.LineProcessors
{
    public class x12st : x12line, Ix12lineProcessor
    {
        public x12st() : base("ST")
        {
            CodeDescription = "ST - Transactioal Set Header";
            LineCode = "ST";
            Fields = new List<x12field>()
            {
                new x12field()
                {
                    Ordinal = 1,
                    FieldName = "Trasactional Set Identifier Code",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 2,
                    MinLen = 3
                },
                new x12field()
                {
                    Ordinal = 2,
                    FieldName = "Trasactional Set Control Number",
                    Format = x12fieldFormat.Numeric,
                    IsRequired = true,
                    MaxLen = 4,
                    MinLen = 9
                },
            };
        }
    }
}
