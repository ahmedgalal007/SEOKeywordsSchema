using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Vessel;
public class Vessel : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Vessel);
}
