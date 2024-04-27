using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.DrugLegalStatus;
public class DrugLegalStatus : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(DrugLegalStatus);
}
