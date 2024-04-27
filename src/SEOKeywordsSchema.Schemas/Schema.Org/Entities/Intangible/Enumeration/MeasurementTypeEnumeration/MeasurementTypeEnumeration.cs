using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MeasurementTypeEnumeration;
public class MeasurementTypeEnumeration : Enumeration
{
    public override string TypeName { get; protected set; } = nameof(MeasurementTypeEnumeration);
}

// TODO BodyMeasurementTypeEnumeration
// TODO WearableMeasurementTypeEnumeration