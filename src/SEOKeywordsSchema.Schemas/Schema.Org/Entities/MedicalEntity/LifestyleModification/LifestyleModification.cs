using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.LifestyleModification;
public class LifestyleModification : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(LifestyleModification);
}
