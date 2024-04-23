using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalGuidelines;
public class MedicalGuidelineContraindication : MedicalGuideline
{
    public override string TypeName { get; protected set; } = nameof(MedicalGuidelineContraindication);
}
