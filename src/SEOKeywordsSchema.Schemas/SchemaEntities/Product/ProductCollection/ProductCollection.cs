using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Products;
public class ProductCollection : Product
{
    public override string TypeName { get; protected set; } = nameof(ProductCollection);
}
