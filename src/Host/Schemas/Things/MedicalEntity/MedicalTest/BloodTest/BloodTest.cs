using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.BloodTests;
public class BloodTest : MedicalTest 
{
    public override string TypeName { get; protected set; } = nameof(BloodTest);
}
