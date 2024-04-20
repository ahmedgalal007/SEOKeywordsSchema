using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.MedicalIndications;
public class ApprovedIndication : MedicalIndication
{
    public override string TypeName { get; protected set; } = nameof(ApprovedIndication);
}
