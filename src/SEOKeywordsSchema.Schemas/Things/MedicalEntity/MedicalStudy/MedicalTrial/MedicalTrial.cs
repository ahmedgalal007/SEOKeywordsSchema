using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.MedicalStudies;
public class MedicalTrial : MedicalStudy 
{
    public override string TypeName { get; protected set; } = nameof(MedicalTrial);
}
