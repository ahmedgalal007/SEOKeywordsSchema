using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalRiskEstimator.MedicalRiskCalculator;
public class MedicalRiskCalculator : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskCalculator);
}
