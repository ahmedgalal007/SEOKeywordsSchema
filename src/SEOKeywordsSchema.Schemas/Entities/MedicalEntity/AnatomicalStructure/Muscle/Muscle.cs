using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.AnatomicalStructures;
public class Bone : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Bone);
}
