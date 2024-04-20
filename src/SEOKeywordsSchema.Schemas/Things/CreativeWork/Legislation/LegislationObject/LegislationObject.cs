using System;

namespace SEOKeywordsSchema.Schemas.Things.CreativeWorks.Legislations;
public class LegislationObject: Legislation
{
    public override string TypeName { get; protected set; } = nameof(LegislationObject);
}
