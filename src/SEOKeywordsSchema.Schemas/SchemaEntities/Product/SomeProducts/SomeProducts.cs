using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Products;
public class SomeProducts : Product
{
    public override string TypeName { get; protected set; } = nameof(SomeProducts);
}
