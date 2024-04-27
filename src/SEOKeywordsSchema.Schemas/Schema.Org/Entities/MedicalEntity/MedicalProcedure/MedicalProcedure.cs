using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalProcedure;
public class MedicalProcedure : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalProcedure);
}
