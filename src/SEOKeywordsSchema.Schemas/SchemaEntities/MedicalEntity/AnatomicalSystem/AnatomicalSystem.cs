using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class AnatomicalSystem : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(AnatomicalSystem);
}
