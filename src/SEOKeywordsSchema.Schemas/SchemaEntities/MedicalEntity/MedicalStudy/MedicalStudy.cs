using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class MedicalStudy : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalStudy);
}
