using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalTest.ImagingTest;
public class ImagingTest : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(ImagingTest);
}
