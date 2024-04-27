using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.AnatomicalStructures;
public class Joint : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Joint);
}
