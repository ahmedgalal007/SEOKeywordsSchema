using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.MedicalIntangibles;
public class MedicalCode : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(MedicalCode);
}
