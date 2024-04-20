using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities;
public class MedicalIndication : MedicalEntity
{
    public override string TypeName { get; protected set; } = nameof(MedicalIndication);
}
