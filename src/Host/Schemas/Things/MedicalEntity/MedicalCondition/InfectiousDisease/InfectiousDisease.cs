using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.MedicalConditions;
public class InfectiousDisease : MedicalCondition
{
    public override string TypeName { get; protected set; } = nameof(InfectiousDisease);
}
