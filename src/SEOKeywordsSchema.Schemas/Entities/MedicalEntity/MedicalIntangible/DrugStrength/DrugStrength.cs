using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalIntangibles;
public class DrugStrength : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(DrugStrength);
}
