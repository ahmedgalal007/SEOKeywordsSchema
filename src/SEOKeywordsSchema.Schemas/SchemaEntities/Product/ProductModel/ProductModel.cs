using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Products;
public class ProductModel : Product
{
    public override string TypeName { get; protected set; } = nameof(ProductModel);
}
