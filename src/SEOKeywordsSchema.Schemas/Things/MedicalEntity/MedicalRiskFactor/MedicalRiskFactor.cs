using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class MedicalRiskFactor : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskFactor);
}
