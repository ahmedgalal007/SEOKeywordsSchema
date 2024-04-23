using SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MedicalEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Entities.Intangibles.Enumerations.MedicalEnumerations.MedicalStudyStatuses;
public class ActiveNotRecruiting : MedicalStudyStatus
{
    public override string TypeName { get; protected set; } = nameof(ActiveNotRecruiting);
}
