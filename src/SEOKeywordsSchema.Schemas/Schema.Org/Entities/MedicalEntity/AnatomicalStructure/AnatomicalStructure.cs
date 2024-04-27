using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure;
public class AnatomicalStructure : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(AnatomicalStructure);
}
