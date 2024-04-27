using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.CarUsageType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.CarUsageType.RentalVehicleUsage;
public class RentalVehicleUsage : CarUsageType
{
    public override string TypeName { get; protected set; } = nameof(RentalVehicleUsage);
}
