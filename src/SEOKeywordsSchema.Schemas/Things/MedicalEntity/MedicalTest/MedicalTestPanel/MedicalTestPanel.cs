using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class MedicalTestPanel : MedicalTest 
{
    public override string TypeName { get; protected set; } = nameof(MedicalTestPanel);
}
