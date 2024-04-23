using System;

namespace SEOKeywordsSchema.Schemas.Entities.Places;
public class Residence : Place
{
    public override string TypeName { get; protected set; } = nameof(Residence);
}
