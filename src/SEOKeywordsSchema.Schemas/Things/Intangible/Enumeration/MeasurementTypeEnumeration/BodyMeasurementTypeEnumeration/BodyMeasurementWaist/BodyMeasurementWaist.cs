﻿using SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.MeasurementTypeEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.BodyMeasurementTypeEnumerations.WearableMeasurementTypeEnumerations;
public class BodyMeasurementWaist : BodyMeasurementTypeEnumeration
{
    public override string TypeName { get; protected set; } = nameof(BodyMeasurementWaist);
}