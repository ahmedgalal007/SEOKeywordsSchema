using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalSystem;
public class AnatomicalSystem : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(AnatomicalSystem);
}
