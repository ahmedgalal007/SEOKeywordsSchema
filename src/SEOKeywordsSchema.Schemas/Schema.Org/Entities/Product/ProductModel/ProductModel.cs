using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products.ProductModel;
public class ProductModel : Product
{
    public override string TypeName { get; protected set; } = nameof(ProductModel);
}
