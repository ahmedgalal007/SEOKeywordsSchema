using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Products;
public class IndividualProduct : Product
{
    public override string TypeName { get; protected set; } = nameof(IndividualProduct);
}
