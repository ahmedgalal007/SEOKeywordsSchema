using System;

namespace SEOKeywordsSchema.Schemas.Entities.Places;
public class AdministrativeArea : Place
{
    public override string TypeName { get; protected set; } = nameof(AdministrativeArea);
}
