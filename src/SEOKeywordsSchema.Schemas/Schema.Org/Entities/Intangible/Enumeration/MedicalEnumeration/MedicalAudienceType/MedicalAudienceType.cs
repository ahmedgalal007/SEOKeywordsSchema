using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalAudienceType;
public class MedicalAudienceType : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicalAudienceType);
}


// TODO Member Clinician
// TODO Member MedicalResearcher