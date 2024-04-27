using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.DrugStrength;
public class DrugStrength : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(DrugStrength);
}
