using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MedicalEnumerations;
public class MedicalObservationalStudyDesign : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicalObservationalStudyDesign);
}


// TODO Member CaseSeries
// TODO Member CohortStudy
// TODO Member CrossSectional
// TODO Member Longitudinal
// TODO Member Observational
// TODO Member Registry
