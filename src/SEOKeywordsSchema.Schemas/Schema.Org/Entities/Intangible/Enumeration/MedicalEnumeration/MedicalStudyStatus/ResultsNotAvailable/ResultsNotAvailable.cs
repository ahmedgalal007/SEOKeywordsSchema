using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalStudyStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalStudyStatus.ResultsNotAvailable;
public class ResultsNotAvailable : MedicalStudyStatus
{
    public override string TypeName { get; protected set; } = nameof(ResultsNotAvailable);
}
