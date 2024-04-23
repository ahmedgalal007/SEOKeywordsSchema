using SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MeasurementTypeEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.BodyMeasurementTypeEnumerations.WearableMeasurementTypeEnumerations;
public class BodyMeasurementWeight : BodyMeasurementTypeEnumeration
{
    public override string TypeName { get; protected set; } = nameof(BodyMeasurementWeight);
}
