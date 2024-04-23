using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.Specialties.MedicalSpecialties;
public class PublicHealth : MedicalSpecialty
{
    public override string TypeName { get; protected set; } = nameof(PublicHealth);
}
