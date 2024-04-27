using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class Substance : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(Substance);
}
