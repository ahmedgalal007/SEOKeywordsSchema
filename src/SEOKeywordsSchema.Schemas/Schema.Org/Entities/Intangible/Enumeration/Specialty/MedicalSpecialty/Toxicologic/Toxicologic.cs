using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.Specialty.MedicalSpecialties;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.Specialty.MedicalSpecialties.Toxicologic;
public class Toxicologic : MedicalSpecialty
{
    public override string TypeName { get; protected set; } = nameof(Toxicologic);
}
