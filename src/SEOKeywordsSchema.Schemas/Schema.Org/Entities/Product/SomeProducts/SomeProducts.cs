using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products.SomeProducts;
public class SomeProducts : Product
{
    public override string TypeName { get; protected set; } = nameof(SomeProducts);
}
