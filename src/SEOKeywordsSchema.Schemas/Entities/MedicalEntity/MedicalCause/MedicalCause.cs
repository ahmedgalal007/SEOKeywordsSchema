using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class MedicalCause : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalCause);
}
