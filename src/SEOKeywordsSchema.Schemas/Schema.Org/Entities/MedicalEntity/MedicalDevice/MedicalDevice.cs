using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalDevice;
public class MedicalDevice : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalDevice);
}
