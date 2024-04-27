using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.Substance;
public class Substance : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(Substance);
}
