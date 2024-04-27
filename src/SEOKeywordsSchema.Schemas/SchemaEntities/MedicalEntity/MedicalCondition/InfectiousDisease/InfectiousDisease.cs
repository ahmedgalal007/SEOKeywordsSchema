using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalConditions;
public class InfectiousDisease : MedicalCondition
{
    public override string TypeName { get; protected set; } = nameof(InfectiousDisease);
}
