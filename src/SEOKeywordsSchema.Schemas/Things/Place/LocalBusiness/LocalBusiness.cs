using System;

namespace SEOKeywordsSchema.Schemas.Things.Places;
public class LocalBusiness : Place
{
    public override string TypeName { get; protected set; } = nameof(LocalBusiness);
}
