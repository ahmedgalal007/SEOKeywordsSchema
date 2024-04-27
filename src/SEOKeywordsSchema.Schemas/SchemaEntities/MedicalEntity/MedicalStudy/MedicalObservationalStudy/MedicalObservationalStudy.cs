using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalStudies;
public class MedicalObservationalStudy : MedicalStudy 
{
    public override string TypeName { get; protected set; } = nameof(MedicalObservationalStudy);
}
