using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.Substances;
public class DietarySupplement : Substance 
{
    public override string TypeName { get; protected set; } = nameof(DietarySupplement);
}
