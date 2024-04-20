using System;

namespace SEOKeywordsSchema.Schemas.Things.Places;
public class Accommodation : Place
{
    public override string TypeName { get; protected set; } = nameof(Accommodation);
}
