using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.MedicalIntangibles;
public class DoseSchedule : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(DoseSchedule);
}
