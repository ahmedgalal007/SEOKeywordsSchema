using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalStudy;
public class MedicalStudy : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalStudy);
}
