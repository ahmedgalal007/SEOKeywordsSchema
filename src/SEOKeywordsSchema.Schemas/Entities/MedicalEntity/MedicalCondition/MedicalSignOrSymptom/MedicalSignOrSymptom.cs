using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalConditions;
public class MedicalSignOrSymptom : MedicalCondition
{
    public override string TypeName { get; protected set; } = nameof(MedicalSignOrSymptom);
}
