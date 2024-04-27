using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalGuideline;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalGuideline.MedicalGuidelineRecommendation;
public class MedicalGuidelineRecommendation : MedicalGuideline
{
    public override string TypeName { get; protected set; } = nameof(MedicalGuidelineRecommendation);
}
