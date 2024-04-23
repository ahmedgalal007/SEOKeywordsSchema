using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalIndications;
public class ApprovedIndication : MedicalIndication
{
    public override string TypeName { get; protected set; } = nameof(ApprovedIndication);
}
