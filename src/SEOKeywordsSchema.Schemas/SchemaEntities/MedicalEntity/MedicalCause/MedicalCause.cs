using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class MedicalCause : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalCause);
}
