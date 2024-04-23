using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.LifestyleModifications;
public class Diet : LifestyleModification
{
    public override string TypeName { get; protected set; } = nameof(Diet);
}
