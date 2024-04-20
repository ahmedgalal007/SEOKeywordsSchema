using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.Substances;
public class DietarySupplement : Substance 
{
    public override string TypeName { get; protected set; } = nameof(DietarySupplement);
}
