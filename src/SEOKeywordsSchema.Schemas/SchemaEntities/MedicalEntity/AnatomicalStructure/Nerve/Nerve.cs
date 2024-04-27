using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.AnatomicalStructures;
public class Nerve : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Nerve);
}
