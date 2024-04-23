using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class MedicalRiskCalculator : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskCalculator);
}
