using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.Substance;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.Substance.Drug;
public class Drug : Substance
{
    public override string TypeName { get; protected set; } = nameof(Drug);
}
