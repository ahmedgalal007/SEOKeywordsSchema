﻿using System;

namespace SEOKeywordsSchema.Schemas.Things.Places;
public class TouristAttraction : Place
{
    public override string TypeName { get; protected set; } = nameof(TouristAttraction);
}