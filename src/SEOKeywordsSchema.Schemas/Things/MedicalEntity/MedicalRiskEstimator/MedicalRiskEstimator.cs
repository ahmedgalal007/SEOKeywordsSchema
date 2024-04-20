using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class MedicalRiskEstimator : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskEstimator);
}
