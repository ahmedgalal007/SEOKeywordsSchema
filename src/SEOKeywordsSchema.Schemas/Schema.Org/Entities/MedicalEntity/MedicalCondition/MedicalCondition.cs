using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalCondition;
public class MedicalCondition : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalCondition);
}
