using System;

namespace SEOKeywordsSchema.Schemas.Entities.Products;
public class ProductModel : Product
{
    public override string TypeName { get; protected set; } = nameof(ProductModel);
}
