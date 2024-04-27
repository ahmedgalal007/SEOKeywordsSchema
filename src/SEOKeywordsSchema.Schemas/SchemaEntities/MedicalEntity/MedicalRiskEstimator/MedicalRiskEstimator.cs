using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class MedicalRiskEstimator : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskEstimator);
}
