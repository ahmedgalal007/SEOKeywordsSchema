using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class DrugClass : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(DrugClass);
}
