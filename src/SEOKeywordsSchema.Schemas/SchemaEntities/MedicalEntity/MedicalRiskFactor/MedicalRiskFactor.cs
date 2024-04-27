using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class MedicalRiskFactor : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskFactor);
}
