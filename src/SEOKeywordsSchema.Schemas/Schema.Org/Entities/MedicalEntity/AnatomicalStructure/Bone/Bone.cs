using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Bone;
public class Muscle : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Muscle);
}
