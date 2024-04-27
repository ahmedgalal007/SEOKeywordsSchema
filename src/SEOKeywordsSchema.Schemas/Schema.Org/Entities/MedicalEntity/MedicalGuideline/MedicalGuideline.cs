using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalGuideline;
public class MedicalGuideline : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalGuideline);
}
