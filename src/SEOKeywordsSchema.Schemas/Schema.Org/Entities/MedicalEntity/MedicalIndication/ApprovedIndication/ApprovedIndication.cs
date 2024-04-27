using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIndication;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIndication.ApprovedIndication;
public class ApprovedIndication : MedicalIndication
{
    public override string TypeName { get; protected set; } = nameof(ApprovedIndication);
}
