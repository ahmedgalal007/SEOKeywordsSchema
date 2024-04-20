using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.MedicalIntangibles;
public class DrugLegalStatus : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(DrugLegalStatus);
}
