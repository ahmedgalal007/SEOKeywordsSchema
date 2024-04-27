using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalTest;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalTest.MedicalTestPanel;
public class MedicalTestPanel : MedicalTest
{
    public override string TypeName { get; protected set; } = nameof(MedicalTestPanel);
}
