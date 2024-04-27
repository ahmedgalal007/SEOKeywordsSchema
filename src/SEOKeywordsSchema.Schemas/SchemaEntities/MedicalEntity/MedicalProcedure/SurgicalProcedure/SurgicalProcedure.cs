using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalProcedures;
public class SurgicalProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(SurgicalProcedure);
}
