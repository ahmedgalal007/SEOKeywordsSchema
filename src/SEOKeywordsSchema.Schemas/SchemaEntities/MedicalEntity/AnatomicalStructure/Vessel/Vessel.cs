using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.AnatomicalStructures;
public class Vessel : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Vessel);
}
