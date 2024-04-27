using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalIntangibles;
public class MedicalCode : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(MedicalCode);
}
