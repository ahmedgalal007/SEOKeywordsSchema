using System;

namespace SEOKeywordsSchema.Schemas.Things.Products;
public class ProductCollection : Product
{
    public override string TypeName { get; protected set; } = nameof(ProductCollection);
}
