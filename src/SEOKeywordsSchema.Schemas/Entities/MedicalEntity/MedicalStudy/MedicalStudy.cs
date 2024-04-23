using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities;
public class MedicalStudy : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalStudy);
}
