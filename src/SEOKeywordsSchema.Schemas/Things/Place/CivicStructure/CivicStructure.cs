using System;

namespace SEOKeywordsSchema.Schemas.Things.Places;
public class CivicStructure : Place
{
    public override string TypeName { get; protected set; } = nameof(CivicStructure);
}
