
using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.MedicalIntangibles;
public class MedicalConditionStage : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(MedicalConditionStage);
}
