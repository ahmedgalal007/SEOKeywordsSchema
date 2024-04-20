using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class ImagingTest : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(ImagingTest);
}
