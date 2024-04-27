using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.AnatomicalStructures;
public class Bone : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Bone);
}
