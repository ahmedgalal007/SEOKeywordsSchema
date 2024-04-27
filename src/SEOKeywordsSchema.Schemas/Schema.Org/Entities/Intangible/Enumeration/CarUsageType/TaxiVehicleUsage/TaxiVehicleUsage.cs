﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.CarUsageType;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.CarUsageType.TaxiVehicleUsage;
public class TaxiVehicleUsage : CarUsageType
{
    public override string TypeName { get; protected set; } = nameof(TaxiVehicleUsage);
}
