﻿using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Service;
using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Service.WebAPI;
public class WebAPI : Service
{
    public override string TypeName { get; protected set; } = nameof(WebAPI);
}
