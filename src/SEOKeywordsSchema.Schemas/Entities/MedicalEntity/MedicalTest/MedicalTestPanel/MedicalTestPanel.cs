using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class MedicalTestPanel : MedicalTest 
{
    public override string TypeName { get; protected set; } = nameof(MedicalTestPanel);
}
