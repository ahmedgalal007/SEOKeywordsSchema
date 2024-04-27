
using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalIntangibles;
public class MedicalConditionStage : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(MedicalConditionStage);
}
