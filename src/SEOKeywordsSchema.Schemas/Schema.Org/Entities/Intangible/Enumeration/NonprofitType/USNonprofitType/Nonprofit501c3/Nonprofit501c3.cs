﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.NonprofitType.USNonprofitType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.NonprofitType.USNonprofitType.Nonprofit501c3;
public class Nonprofit501c3 : USNonprofitType
{
    public override string TypeName { get; protected set; } = nameof(Nonprofit501c3);
}
