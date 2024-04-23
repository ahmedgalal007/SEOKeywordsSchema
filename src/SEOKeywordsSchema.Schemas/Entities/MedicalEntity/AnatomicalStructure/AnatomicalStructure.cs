using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class AnatomicalStructure : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(AnatomicalStructure);
}
