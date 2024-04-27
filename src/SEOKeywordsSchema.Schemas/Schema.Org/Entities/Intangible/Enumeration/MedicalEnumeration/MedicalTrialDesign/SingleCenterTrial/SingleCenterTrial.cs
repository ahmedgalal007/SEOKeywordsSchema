using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalTrialDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Intangible.Enumeration.MedicalEnumeration.MedicalTrialDesign.SingleCenterTrial;
public class SingleCenterTrial : MedicalTrialDesign
{
    public override string TypeName { get; protected set; } = nameof(SingleCenterTrial);
}
