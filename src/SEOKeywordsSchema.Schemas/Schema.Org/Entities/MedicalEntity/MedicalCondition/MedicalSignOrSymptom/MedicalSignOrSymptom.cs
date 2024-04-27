using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalCondition;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalCondition.MedicalSignOrSymptom;
public class MedicalSignOrSymptom : MedicalCondition
{
    public override string TypeName { get; protected set; } = nameof(MedicalSignOrSymptom);
}
