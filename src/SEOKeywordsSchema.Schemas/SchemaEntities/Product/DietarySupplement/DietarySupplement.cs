using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Products;
public class DietarySupplement : Product
{
    public override string TypeName { get; protected set; } = nameof(DietarySupplement);
}
