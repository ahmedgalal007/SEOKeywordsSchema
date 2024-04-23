using SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MedicalEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MedicalEnumerations.MedicalAudienceTypes;
public class MedicalResearcher : MedicalAudienceType
{
    public override string TypeName { get; protected set; } = nameof(MedicalResearcher);
}
