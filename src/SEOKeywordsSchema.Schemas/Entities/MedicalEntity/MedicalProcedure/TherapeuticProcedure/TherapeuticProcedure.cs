using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalProcedures;
public class TherapeuticProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(TherapeuticProcedure);
}
