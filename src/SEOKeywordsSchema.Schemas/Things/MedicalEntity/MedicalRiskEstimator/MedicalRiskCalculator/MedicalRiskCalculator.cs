using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class MedicalRiskCalculator : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskCalculator);
}
