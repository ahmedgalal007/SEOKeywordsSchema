using System;

namespace SEOKeywordsSchema.Schemas.Entities.CreativeWorks.Legislations;
public class LegislationObject: Legislation
{
    public override string TypeName { get; protected set; } = nameof(LegislationObject);
}
