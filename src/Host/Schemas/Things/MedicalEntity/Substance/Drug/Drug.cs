using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.Substances;
public class Drug : Substance 
{
    public override string TypeName { get; protected set; } = nameof(Drug);
}
