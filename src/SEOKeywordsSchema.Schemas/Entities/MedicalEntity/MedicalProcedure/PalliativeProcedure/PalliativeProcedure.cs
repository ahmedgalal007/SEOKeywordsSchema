using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalProcedures;
public class PalliativeProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(PalliativeProcedure);
}
