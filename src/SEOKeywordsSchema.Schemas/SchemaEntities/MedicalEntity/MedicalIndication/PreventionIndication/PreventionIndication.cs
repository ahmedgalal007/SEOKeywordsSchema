using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalIndications;
public class PreventionIndication : MedicalIndication
{
    public override string TypeName { get; protected set; } = nameof(PreventionIndication);
}
