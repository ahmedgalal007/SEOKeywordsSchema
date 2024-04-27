using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalGuidelines;
public class MedicalGuidelineContraindication : MedicalGuideline
{
    public override string TypeName { get; protected set; } = nameof(MedicalGuidelineContraindication);
}
