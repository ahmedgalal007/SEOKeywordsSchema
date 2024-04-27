using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalRiskEstimator;
public class MedicalRiskEstimator : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskEstimator);
}
