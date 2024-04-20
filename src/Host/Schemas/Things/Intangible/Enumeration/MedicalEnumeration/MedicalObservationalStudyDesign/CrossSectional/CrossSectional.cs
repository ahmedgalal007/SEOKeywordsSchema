using FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations.MedicalObservationalStudyDesignes;
public class CrossSectional : MedicalObservationalStudyDesign
{
    public override string TypeName { get; protected set; } = nameof(CrossSectional);
}
