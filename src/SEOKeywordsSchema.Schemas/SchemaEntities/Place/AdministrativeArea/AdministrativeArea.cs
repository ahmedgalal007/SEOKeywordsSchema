using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Places;
public class AdministrativeArea : Place
{
    public override string TypeName { get; protected set; } = nameof(AdministrativeArea);
}
