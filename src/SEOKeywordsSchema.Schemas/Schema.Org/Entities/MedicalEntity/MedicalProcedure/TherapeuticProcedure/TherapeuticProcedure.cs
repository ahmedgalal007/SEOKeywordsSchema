using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalProcedure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalProcedure.TherapeuticProcedure;
public class TherapeuticProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(TherapeuticProcedure);
}
