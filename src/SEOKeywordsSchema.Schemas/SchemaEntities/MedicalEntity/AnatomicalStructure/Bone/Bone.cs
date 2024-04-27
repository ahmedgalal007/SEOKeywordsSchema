using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.AnatomicalStructures;
public class Muscle : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Muscle);
}
