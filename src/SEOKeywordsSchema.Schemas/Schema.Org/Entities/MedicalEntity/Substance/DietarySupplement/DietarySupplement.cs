using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.Substance;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.Substance.DietarySupplement;
public class DietarySupplement : Substance
{
    public override string TypeName { get; protected set; } = nameof(DietarySupplement);
}
