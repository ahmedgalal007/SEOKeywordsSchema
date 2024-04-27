using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MedicalEnumerations;
public class DrugPrescriptionStatus : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(DrugPrescriptionStatus);
}


// TODO Member OTC
// TODO Member PrescriptionOnly