using System;

namespace SEOKeywordsSchema.Schemas.Entities.Products;
public class ProductCollection : Product
{
    public override string TypeName { get; protected set; } = nameof(ProductCollection);
}
