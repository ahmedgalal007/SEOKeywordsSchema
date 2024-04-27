
using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.MedicalConditionStage;
public class MedicalConditionStage : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(MedicalConditionStage);
}
