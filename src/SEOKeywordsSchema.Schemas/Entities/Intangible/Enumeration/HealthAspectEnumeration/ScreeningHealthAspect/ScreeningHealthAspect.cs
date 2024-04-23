using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.HealthAspectEnumerations;
public class ScreeningHealthAspect : HealthAspectEnumeration
{
    public override string TypeName { get; protected set; } = nameof(ScreeningHealthAspect);
}
