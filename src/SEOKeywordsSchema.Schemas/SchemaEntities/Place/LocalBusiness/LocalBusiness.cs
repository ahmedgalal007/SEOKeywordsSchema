using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Places;
public class LocalBusiness : Place
{
    public override string TypeName { get; protected set; } = nameof(LocalBusiness);
}
