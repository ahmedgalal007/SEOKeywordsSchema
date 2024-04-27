using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.Substances;
public class Drug : Substance 
{
    public override string TypeName { get; protected set; } = nameof(Drug);
}
