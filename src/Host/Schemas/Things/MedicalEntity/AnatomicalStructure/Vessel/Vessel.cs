using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.AnatomicalStructures;
public class Vessel : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Vessel);
}
