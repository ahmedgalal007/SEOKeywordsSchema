using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.HealthAspectEnumerations;
public class OverviewHealthAspect : HealthAspectEnumeration
{
    public override string TypeName { get; protected set; } = nameof(OverviewHealthAspect);
}
