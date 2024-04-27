using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalRiskEstimator.MedicalRiskScore;
public class MedicalRiskScore : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskScore);
}
