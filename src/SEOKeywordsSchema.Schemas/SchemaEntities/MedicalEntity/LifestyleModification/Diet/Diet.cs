using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.LifestyleModifications;
public class Diet : LifestyleModification
{
    public override string TypeName { get; protected set; } = nameof(Diet);
}
