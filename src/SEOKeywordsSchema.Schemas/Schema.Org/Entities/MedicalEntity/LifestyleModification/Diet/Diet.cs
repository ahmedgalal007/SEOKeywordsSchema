using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.LifestyleModification;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.LifestyleModification.Diet;
public class Diet : LifestyleModification
{
    public override string TypeName { get; protected set; } = nameof(Diet);
}
