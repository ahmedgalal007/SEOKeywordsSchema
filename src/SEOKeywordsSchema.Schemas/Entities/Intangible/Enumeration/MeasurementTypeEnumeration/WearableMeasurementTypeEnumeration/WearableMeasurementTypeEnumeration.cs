using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MeasurementTypeEnumerations;
public class WearableMeasurementTypeEnumeration : MeasurementTypeEnumeration
{
    public override string TypeName { get; protected set; } = nameof(WearableMeasurementTypeEnumeration);
}
