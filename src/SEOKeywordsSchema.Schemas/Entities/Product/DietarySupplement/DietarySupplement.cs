using System;

namespace SEOKeywordsSchema.Schemas.Entities.Products;
public class DietarySupplement : Product
{
    public override string TypeName { get; protected set; } = nameof(DietarySupplement);
}
