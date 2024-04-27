using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalCondition;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalCondition.InfectiousDisease;
public class InfectiousDisease : MedicalCondition
{
    public override string TypeName { get; protected set; } = nameof(InfectiousDisease);
}
