﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.NonprofitTypes.USNonprofitTypes;
public class Nonprofit501c5 : USNonprofitType
{
    public override string TypeName { get; protected set; } = nameof(Nonprofit501c5);
}