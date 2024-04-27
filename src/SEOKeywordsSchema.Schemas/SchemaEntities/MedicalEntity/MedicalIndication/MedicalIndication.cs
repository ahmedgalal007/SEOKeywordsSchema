using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities;
public class MedicalIndication : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalIndication);
}
