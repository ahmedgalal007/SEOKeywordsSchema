using System;

namespace SEOKeywordsSchema.Schemas.Things.Products;
public class ProductGroup : Product
{
    public override string TypeName { get; protected set; } = nameof(ProductGroup);
}
