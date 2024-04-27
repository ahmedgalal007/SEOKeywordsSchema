using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalStudy;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalStudy.MedicalObservationalStudy;
public class MedicalObservationalStudy : MedicalStudy
{
    public override string TypeName { get; protected set; } = nameof(MedicalObservationalStudy);
}
