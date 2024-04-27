using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products.IndividualProduct;
public class IndividualProduct : Product
{
    public override string TypeName { get; protected set; } = nameof(IndividualProduct);
}
