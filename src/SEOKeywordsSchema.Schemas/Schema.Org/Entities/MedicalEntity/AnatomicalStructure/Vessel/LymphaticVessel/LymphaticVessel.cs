using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Vessel;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.AnatomicalStructure.Vessel.LymphaticVessel;
public class LymphaticVessel : Vessel
{
    public override string TypeName { get; protected set; } = nameof(LymphaticVessel);
}
