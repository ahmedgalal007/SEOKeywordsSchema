using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalGuideline;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalGuideline.MedicalGuidelineContraindication;
public class MedicalGuidelineContraindication : MedicalGuideline
{
    public override string TypeName { get; protected set; } = nameof(MedicalGuidelineContraindication);
}
