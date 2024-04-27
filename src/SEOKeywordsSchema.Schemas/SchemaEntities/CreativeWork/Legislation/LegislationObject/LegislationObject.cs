using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.Legislations;
public class LegislationObject: Legislation
{
    public override string TypeName { get; protected set; } = nameof(LegislationObject);
}
