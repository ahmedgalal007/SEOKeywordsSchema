using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalIntangibles;
public class DrugLegalStatus : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(DrugLegalStatus);
}
