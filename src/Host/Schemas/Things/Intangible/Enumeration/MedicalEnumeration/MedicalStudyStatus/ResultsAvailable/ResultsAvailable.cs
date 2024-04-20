using FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSH.WebApi.Domain.Schemas.Things.Intangibles.Enumerations.MedicalEnumerations.MedicalStudyStatuses;
public class ResultsAvailable : MedicalStudyStatus
{
    public override string TypeName { get; protected set; } = nameof(ResultsAvailable);
}
