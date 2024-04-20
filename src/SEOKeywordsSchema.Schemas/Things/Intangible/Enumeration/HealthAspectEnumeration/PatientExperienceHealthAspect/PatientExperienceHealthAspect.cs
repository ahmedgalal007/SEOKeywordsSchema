using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.HealthAspectEnumerations;
public class PatientExperienceHealthAspect : HealthAspectEnumeration
{
    public override string TypeName { get; protected set; } = nameof(PatientExperienceHealthAspect);
}
