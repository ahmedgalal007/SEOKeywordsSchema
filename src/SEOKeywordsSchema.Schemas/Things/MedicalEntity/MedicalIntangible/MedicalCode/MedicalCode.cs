using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.MedicalIntangibles;
public class MedicalCode : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(MedicalCode);
}
