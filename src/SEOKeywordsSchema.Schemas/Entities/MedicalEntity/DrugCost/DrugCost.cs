using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class DrugCost : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(DrugCost);
}
