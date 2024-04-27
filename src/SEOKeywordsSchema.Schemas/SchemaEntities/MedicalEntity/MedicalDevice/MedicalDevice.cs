using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class MedicalDevice : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalDevice);
}
