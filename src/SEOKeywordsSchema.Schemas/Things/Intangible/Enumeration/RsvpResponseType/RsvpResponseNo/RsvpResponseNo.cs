﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.RsvpResponseTypes;
public class RsvpResponseNo : RsvpResponseType
{
    public override string TypeName { get; protected set; } = nameof(RsvpResponseNo);
}