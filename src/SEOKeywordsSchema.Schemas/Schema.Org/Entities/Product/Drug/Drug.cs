using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products.Drug;
public class Drug : Product
{
    public override string TypeName { get; protected set; } = nameof(Drug);
}
