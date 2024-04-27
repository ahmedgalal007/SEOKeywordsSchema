using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalProcedure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalProcedure.PalliativeProcedure;
public class PalliativeProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(PalliativeProcedure);
}
