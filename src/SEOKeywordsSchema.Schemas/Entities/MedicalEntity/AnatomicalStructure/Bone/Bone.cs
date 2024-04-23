using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.AnatomicalStructures;
public class Muscle : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Muscle);
}
