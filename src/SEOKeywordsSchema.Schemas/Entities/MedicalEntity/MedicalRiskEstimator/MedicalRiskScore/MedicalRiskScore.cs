using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class MedicalRiskScore : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskScore);
}
