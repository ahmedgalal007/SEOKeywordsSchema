using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalAudienceType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalAudienceType.MedicalResearcher;
public class MedicalResearcher : MedicalAudienceType
{
    public override string TypeName { get; protected set; } = nameof(MedicalResearcher);
}
