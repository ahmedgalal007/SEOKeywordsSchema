﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Audiences;
public class BusinessAudience : Audience
{
    public override string TypeName { get; protected set; } = nameof(BusinessAudience);
}
