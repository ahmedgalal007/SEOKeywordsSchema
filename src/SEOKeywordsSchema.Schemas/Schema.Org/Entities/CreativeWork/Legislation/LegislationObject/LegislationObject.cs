using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Legislation;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork.Legislation.LegislationObject;
public class LegislationObject : Legislation
{
    public override string TypeName { get; protected set; } = nameof(LegislationObject);
}
