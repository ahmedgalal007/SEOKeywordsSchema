using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class MedicalProcedure : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalProcedure);
}
