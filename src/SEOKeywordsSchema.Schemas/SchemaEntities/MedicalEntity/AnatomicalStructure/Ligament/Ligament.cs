using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.AnatomicalStructures;
public class Ligament : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Ligament);
}
