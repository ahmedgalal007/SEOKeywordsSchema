using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class Substance : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(Substance);
}
