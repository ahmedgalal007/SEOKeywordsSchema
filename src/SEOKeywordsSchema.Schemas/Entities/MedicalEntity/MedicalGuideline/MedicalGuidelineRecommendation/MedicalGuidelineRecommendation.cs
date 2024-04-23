using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalGuidelines;
public class MedicalGuidelineRecommendation : MedicalGuideline
{
    public override string TypeName { get; protected set; } = nameof(MedicalGuidelineRecommendation);
}
