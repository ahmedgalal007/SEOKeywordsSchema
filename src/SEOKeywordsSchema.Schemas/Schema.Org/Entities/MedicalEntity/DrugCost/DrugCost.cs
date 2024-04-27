using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.DrugCost;
public class DrugCost : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(DrugCost);
}
