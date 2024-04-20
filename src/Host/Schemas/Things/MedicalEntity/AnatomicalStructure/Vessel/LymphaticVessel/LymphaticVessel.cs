using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.AnatomicalStructures.Vessels;
public class LymphaticVessel : Vessel
{
    public override string TypeName { get; protected set; } = nameof(LymphaticVessel);
}
