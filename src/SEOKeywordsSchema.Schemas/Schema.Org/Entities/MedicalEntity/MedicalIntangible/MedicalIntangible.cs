using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible;
public class MedicalIntangible : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalIntangible);
}
