using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MedicalEnumerations;
public class MedicalStudyStatus : MedicalEnumeration
{
    public override string TypeName { get; protected set; } = nameof(MedicalStudyStatus);
}


// TODO Member ActiveNotRecruiting
// TODO Member Completed
// TODO Member EnrollingByInvitation
// TODO Member NotYetRecruiting
// TODO Member Recruiting
// TODO Member ResultsAvailable
// TODO Member ResultsNotAvailable
// TODO Member Suspended
// TODO Member Terminated
// TODO Member Withdrawn