using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class MedicalIntangible : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalIntangible);
}
