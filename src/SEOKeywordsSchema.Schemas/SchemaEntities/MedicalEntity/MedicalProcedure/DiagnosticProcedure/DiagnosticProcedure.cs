using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalProcedures;
public class DiagnosticProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(DiagnosticProcedure);
}
