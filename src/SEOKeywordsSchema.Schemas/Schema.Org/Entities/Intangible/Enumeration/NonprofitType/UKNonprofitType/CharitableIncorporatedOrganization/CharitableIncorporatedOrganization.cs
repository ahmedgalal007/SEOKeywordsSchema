﻿using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.NonprofitType.UKNonprofitType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.NonprofitType.UKNonprofitType.CharitableIncorporatedOrganization;
public class CharitableIncorporatedOrganization : UKNonprofitType
{
    public override string TypeName { get; protected set; } = nameof(CharitableIncorporatedOrganization);
}
