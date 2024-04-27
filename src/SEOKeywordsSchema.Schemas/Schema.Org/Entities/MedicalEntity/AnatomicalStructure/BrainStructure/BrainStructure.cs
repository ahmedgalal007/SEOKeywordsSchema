using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.BrainStructure;
public class BrainStructure : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(BrainStructure);
}
