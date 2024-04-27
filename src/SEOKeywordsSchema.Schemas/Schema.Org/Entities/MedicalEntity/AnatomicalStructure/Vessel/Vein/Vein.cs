using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Vessel;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Vessel.Vein;
public class Vein : Vessel
{
    public override string TypeName { get; protected set; } = nameof(Vein);
}
