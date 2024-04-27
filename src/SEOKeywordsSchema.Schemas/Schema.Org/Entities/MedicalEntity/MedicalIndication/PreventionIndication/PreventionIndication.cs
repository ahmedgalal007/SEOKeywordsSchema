using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIndication;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIndication.PreventionIndication;
public class PreventionIndication : MedicalIndication
{
    public override string TypeName { get; protected set; } = nameof(PreventionIndication);
}
