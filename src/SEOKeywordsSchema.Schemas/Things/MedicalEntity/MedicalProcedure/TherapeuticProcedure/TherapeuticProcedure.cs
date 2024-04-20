using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.MedicalProcedures;
public class TherapeuticProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(TherapeuticProcedure);
}
