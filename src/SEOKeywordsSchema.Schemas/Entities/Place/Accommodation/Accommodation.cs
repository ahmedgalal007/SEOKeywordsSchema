using System;

namespace SEOKeywordsSchema.Schemas.Entities.Places;
public class Accommodation : Place
{
    public override string TypeName { get; protected set; } = nameof(Accommodation);
}
