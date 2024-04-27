using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalTest;
public class MedicalTest : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalTest);
}
