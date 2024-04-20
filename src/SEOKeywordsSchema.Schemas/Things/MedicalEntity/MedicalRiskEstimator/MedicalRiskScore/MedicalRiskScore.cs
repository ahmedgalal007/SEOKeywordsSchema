using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class MedicalRiskScore : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskScore);
}
