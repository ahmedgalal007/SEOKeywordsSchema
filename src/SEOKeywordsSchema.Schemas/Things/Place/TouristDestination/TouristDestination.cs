using System;

namespace SEOKeywordsSchema.Schemas.Things.Places;
public class TouristDestination : Place
{
    public override string TypeName { get; protected set; } = nameof(TouristDestination);
}
