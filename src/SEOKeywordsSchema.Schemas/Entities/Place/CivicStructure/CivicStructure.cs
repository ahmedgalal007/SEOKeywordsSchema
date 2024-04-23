using System;

namespace SEOKeywordsSchema.Schemas.Entities.Places;
public class CivicStructure : Place
{
    public override string TypeName { get; protected set; } = nameof(CivicStructure);
}
