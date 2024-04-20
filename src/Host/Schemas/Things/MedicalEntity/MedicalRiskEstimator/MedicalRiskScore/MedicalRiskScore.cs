using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities;
public class MedicalRiskScore : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalRiskScore);
}
