﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.OfferItemCondition;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.OfferItemCondition.UsedCondition;
public class UsedCondition : OfferItemCondition
{
    public override string TypeName { get; protected set; } = nameof(UsedCondition);
}
