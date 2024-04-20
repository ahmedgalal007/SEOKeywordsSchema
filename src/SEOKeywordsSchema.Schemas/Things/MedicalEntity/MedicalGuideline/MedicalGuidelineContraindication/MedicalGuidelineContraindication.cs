using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.MedicalGuidelines;
public class MedicalGuidelineContraindication : MedicalGuideline
{
    public override string TypeName { get; protected set; } = nameof(MedicalGuidelineContraindication);
}
