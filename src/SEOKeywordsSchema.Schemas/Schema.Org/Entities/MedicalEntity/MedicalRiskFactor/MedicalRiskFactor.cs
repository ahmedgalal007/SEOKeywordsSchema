using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalRiskFactor;
public class MedicalRiskFactor : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskFactor);
}
