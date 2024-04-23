using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalStudies;
public class MedicalObservationalStudy : MedicalStudy 
{
    public override string TypeName { get; protected set; } = nameof(MedicalObservationalStudy);
}
