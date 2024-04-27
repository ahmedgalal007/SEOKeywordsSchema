using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.DrugPrescriptionStatus;
public class DrugPrescriptionStatus : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(DrugPrescriptionStatus);
}


// TODO Member OTC
// TODO Member PrescriptionOnly