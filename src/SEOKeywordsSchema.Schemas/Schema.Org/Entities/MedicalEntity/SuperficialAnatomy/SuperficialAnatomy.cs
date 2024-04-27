using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.SuperficialAnatomy;
public class SuperficialAnatomy : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(SuperficialAnatomy);
}
