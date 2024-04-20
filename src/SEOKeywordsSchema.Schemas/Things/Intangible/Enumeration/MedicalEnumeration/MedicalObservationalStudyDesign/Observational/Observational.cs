using SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations.MedicalObservationalStudyDesignes;
public class Observational : MedicalObservationalStudyDesign
{
    public override string TypeName { get; protected set; } = nameof(Observational);
}
