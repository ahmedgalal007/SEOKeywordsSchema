using SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MeasurementTypeEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MeasurementTypeEnumerations.BodyMeasurementTypeEnumerations;
public class BodyMeasurementArm : BodyMeasurementTypeEnumeration
{
    public override string TypeName { get; protected set; } = nameof(BodyMeasurementArm);
}
