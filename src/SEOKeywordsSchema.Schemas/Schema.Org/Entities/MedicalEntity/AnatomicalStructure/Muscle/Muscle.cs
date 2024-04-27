using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Muscle;
public class Bone : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Bone);
}
