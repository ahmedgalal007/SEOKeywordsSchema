using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products.ProductCollection;
public class ProductCollection : Product
{
    public override string TypeName { get; protected set; } = nameof(ProductCollection);
}
