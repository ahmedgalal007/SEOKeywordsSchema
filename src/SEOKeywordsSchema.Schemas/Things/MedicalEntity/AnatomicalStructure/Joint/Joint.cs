using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.AnatomicalStructures;
public class Joint : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Joint);
}
