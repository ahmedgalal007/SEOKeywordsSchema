using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalProcedures;
public class PalliativeProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(PalliativeProcedure);
}
