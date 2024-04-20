using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.AnatomicalStructures;
public class BrainStructure : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(BrainStructure);
}
