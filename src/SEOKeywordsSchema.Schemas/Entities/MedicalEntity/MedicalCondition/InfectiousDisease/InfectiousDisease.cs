using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalConditions;
public class InfectiousDisease : MedicalCondition
{
    public override string TypeName { get; protected set; } = nameof(InfectiousDisease);
}
