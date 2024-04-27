using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.StructuredValues;
public class ShippingRateSettings : StructuredValue
{
    public override string TypeName { get; protected set; } = nameof(ShippingRateSettings);
}
