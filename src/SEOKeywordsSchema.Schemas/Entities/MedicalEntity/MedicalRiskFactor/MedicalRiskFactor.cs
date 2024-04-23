using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class MedicalRiskFactor : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskFactor);
}
