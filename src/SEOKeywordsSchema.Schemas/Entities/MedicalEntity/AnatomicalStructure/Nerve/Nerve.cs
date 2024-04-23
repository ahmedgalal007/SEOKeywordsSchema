using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.AnatomicalStructures;
public class Nerve : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Nerve);
}
