﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.MediaSubscription;
public class MediaSubscription : Intangible
{
    public override string TypeName { get; protected set; } = nameof(MediaSubscription);
}
