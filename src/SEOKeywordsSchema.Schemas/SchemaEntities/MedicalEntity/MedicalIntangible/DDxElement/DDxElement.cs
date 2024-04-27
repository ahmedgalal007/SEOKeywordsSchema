using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalIntangibles;
public class DDxElement : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(DDxElement);
}
