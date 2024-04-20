using System;

namespace SEOKeywordsSchema.Schemas.Things.Products;
public class IndividualProduct : Product
{
    public override string TypeName { get; protected set; } = nameof(IndividualProduct);
}
