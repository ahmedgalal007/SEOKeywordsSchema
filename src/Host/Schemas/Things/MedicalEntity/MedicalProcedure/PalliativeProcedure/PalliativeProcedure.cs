using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.MedicalProcedures;
public class PalliativeProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(PalliativeProcedure);
}
