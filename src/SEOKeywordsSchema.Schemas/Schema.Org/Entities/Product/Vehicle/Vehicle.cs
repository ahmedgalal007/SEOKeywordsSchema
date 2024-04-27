using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Products.Vehicle;
public class Vehicle : Product
{
    public override string TypeName { get; protected set; } = nameof(Vehicle);
}
