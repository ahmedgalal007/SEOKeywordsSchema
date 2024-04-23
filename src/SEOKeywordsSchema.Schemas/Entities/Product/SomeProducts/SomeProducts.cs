using System;

namespace SEOKeywordsSchema.Schemas.Entities.Products;
public class SomeProducts : Product
{
    public override string TypeName { get; protected set; } = nameof(SomeProducts);
}
