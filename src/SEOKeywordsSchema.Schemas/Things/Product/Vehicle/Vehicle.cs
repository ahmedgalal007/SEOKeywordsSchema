using System;

namespace SEOKeywordsSchema.Schemas.Things.Products;
public class Vehicle : Product
{
    public override string TypeName { get; protected set; } = nameof(Vehicle);
}
