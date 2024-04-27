using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products.DietarySupplement;
public class DietarySupplement : Product
{
    public override string TypeName { get; protected set; } = nameof(DietarySupplement);
}
