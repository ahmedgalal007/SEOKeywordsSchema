using System;

namespace SEOKeywordsSchema.Schemas.Entities.Places;
public class LocalBusiness : Place
{
    public override string TypeName { get; protected set; } = nameof(LocalBusiness);
}
