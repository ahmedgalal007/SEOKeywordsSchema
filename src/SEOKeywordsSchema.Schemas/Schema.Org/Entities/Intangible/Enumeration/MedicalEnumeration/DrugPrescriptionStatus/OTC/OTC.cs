using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.DrugPrescriptionStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.DrugPrescriptionStatus.OTC;
public class OTC : DrugPrescriptionStatus
{
    public override string TypeName { get; protected set; } = nameof(OTC);
}
