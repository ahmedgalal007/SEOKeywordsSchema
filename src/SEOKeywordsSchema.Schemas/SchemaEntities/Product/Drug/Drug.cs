using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Products;
public class Drug : Product
{
    public override string TypeName { get; protected set; } = nameof(Drug);
}
