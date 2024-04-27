using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.AnatomicalStructures.Vessels;
public class LymphaticVessel : Vessel
{
    public override string TypeName { get; protected set; } = nameof(LymphaticVessel);
}
