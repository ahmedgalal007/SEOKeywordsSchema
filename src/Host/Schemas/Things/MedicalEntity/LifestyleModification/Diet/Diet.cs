using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.LifestyleModifications;
public class Diet : LifestyleModification
{
    public override string TypeName { get; protected set; } = nameof(Diet);
}
