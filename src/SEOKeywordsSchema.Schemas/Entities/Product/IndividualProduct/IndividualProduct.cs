using System;

namespace SEOKeywordsSchema.Schemas.Entities.Products;
public class IndividualProduct : Product
{
    public override string TypeName { get; protected set; } = nameof(IndividualProduct);
}
