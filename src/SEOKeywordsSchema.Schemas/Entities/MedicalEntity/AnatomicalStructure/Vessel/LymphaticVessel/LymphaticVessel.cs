using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.AnatomicalStructures.Vessels;
public class LymphaticVessel : Vessel
{
    public override string TypeName { get; protected set; } = nameof(LymphaticVessel);
}
