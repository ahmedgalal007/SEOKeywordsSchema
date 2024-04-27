﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.HealthAspectEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.HealthAspectEnumeration.SafetyHealthAspect;
public class SafetyHealthAspect : HealthAspectEnumeration
{
    public override string TypeName { get; protected set; } = nameof(SafetyHealthAspect);
}
