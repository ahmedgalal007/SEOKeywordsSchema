﻿using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Series;
using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Series.CreativeWorkSeries;
public class CreativeWorkSeries : Series
{
    public override string TypeName { get; protected set; } = nameof(CreativeWorkSeries);
}
