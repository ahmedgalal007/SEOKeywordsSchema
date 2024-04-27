using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalCause;
public class MedicalCause : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalCause);
}
