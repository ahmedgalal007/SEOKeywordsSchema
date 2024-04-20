using System;

namespace SEOKeywordsSchema.Schemas.Things.Products;
public class DietarySupplement : Product
{
    public override string TypeName { get; protected set; } = nameof(DietarySupplement);
}
