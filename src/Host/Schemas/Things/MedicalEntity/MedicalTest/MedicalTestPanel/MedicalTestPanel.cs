using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities;
public class MedicalTestPanel : MedicalTest 
{
    public override string TypeName { get; protected set; } = nameof(MedicalTestPanel);
}
