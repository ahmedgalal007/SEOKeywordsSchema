using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products.ProductGroup;
public class ProductGroup : Product
{
    public override string TypeName { get; protected set; } = nameof(ProductGroup);
}
