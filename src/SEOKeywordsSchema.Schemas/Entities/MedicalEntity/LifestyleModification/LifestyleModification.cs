using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class LifestyleModification : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(LifestyleModification);
}
