using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class DrugCost : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(DrugCost);
}
