using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.MedicalCode;
public class MedicalCode : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(MedicalCode);
}
