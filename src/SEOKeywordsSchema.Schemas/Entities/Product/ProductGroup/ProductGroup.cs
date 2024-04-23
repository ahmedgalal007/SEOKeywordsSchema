using System;

namespace SEOKeywordsSchema.Schemas.Entities.Products;
public class ProductGroup : Product
{
    public override string TypeName { get; protected set; } = nameof(ProductGroup);
}
