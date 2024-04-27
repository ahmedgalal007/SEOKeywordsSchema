using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class LifestyleModification : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(LifestyleModification);
}
