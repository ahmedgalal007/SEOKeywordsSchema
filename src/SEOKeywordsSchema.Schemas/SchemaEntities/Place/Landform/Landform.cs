using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Places;
public class Landform : Place
{
    public override string TypeName { get; protected set; } = nameof(Landform);
}
