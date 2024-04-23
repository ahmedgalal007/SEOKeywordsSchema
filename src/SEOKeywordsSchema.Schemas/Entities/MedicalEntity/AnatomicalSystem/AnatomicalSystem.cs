using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class AnatomicalSystem : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(AnatomicalSystem);
}
