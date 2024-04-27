using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalProcedure;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalProcedure.SurgicalProcedure;
public class SurgicalProcedure : MedicalProcedure
{
    public override string TypeName { get; protected set; } = nameof(SurgicalProcedure);
}
