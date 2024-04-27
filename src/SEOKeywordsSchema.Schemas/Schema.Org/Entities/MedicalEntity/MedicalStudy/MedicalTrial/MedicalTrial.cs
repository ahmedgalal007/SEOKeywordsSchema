using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalStudy;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalStudy.MedicalTrial;
public class MedicalTrial : MedicalStudy
{
    public override string TypeName { get; protected set; } = nameof(MedicalTrial);
}
