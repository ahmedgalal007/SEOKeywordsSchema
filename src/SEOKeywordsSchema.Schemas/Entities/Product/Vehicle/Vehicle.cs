using System;

namespace SEOKeywordsSchema.Schemas.Entities.Products;
public class Vehicle : Product
{
    public override string TypeName { get; protected set; } = nameof(Vehicle);
}
