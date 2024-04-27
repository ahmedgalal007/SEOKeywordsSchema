using SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MedicalEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Intangibles.Enumerations.MedicalEnumerations.MedicalTrialDesignes;
public class SingleCenterTrial : MedicalTrialDesign
{
    public override string TypeName { get; protected set; } = nameof(SingleCenterTrial);
}
