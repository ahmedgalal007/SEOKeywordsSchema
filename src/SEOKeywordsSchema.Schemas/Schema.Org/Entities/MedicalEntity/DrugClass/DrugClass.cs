using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.DrugClass;
public class DrugClass : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(DrugClass);
}
