using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class MedicalDevice : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalDevice);
}
