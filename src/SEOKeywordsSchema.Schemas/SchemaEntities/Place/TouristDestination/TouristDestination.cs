using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Places;
public class TouristDestination : Place
{
    public override string TypeName { get; protected set; } = nameof(TouristDestination);
}
