using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class SuperficialAnatomy : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(SuperficialAnatomy);
}
