using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.MedicalProcedures;
public class DiagnosticProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(DiagnosticProcedure);
}
