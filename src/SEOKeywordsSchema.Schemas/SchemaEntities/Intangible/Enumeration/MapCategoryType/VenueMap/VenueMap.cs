﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MapCategoryTypes;
public class VenueMap : MapCategoryType
{
    public override string TypeName { get; protected set; } = nameof(VenueMap);
}