using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class Substance : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(Substance);
}
