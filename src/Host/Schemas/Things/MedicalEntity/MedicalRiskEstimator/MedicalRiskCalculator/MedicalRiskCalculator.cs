using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities;
public class MedicalRiskCalculator : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskCalculator);
}
