using System;

namespace SEOKeywordsSchema.Schemas.Things.Places;
public class AdministrativeArea : Place
{
    public override string TypeName { get; protected set; } = nameof(AdministrativeArea);
}
