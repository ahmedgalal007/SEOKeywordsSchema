﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.CarUsageTypes;
public class TaxiVehicleUsage : CarUsageType
{
    public override string TypeName { get; protected set; } = nameof(TaxiVehicleUsage);
}