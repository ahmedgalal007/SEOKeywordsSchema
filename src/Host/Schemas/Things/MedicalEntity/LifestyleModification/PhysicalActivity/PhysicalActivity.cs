using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.LifestyleModifications;
public class PhysicalActivity : LifestyleModification
{
    public override string TypeName { get; protected set; } = nameof(PhysicalActivity);
}
