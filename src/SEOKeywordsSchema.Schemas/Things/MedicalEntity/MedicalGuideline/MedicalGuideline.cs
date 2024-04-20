using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class MedicalGuideline : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalGuideline);
}
