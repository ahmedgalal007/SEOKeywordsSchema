using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalTest;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalTest.BloodTest;
public class BloodTest : MedicalTest
{
    public override string TypeName { get; protected set; } = nameof(BloodTest);
}
