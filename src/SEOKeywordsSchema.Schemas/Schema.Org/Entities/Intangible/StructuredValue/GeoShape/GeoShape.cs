using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.StructuredValue;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.StructuredValue.GeoShape;
public class GeoShape : StructuredValue
{
    public override string TypeName { get; protected set; } = nameof(GeoShape);
}
