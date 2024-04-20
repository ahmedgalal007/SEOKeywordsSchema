using System;

namespace SEOKeywordsSchema.Schemas.Things.Places;
public class Landform : Place
{
    public override string TypeName { get; protected set; } = nameof(Landform);
}
