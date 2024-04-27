using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalEvidenceLevel;
public class MedicalEvidenceLevel : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicalEvidenceLevel);
}

// TODO Member EvidenceLevelA
// TODO Member EvidenceLevelB
// TODO Member EvidenceLevelC