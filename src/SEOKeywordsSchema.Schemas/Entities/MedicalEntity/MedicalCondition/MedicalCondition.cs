using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class MedicalCondition : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalCondition);
}
