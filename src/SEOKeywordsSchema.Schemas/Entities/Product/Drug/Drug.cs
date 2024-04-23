using System;

namespace SEOKeywordsSchema.Schemas.Entities.Products;
public class Drug : Product
{
    public override string TypeName { get; protected set; } = nameof(Drug);
}
