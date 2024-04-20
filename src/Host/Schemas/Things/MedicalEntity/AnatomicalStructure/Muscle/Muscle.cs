using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.AnatomicalStructures;
public class Bone : AnatomicalStructure
{
    public override string TypeName { get; protected set; } = nameof(Bone);
}
