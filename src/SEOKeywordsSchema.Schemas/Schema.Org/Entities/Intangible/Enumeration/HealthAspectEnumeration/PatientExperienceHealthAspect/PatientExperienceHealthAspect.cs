using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.HealthAspectEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.HealthAspectEnumeration.PatientExperienceHealthAspect;
public class PatientExperienceHealthAspect : HealthAspectEnumeration
{
    public override string TypeName { get; protected set; } = nameof(PatientExperienceHealthAspect);
}
