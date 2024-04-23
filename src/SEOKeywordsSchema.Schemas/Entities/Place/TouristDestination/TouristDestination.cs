using System;

namespace SEOKeywordsSchema.Schemas.Entities.Places;
public class TouristDestination : Place
{
    public override string TypeName { get; protected set; } = nameof(TouristDestination);
}
