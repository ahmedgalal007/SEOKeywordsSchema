using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class MedicalDevice : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalDevice);
}
