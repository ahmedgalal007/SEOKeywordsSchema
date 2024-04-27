using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalProcedure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalProcedure.DiagnosticProcedure;
public class DiagnosticProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(DiagnosticProcedure);
}
