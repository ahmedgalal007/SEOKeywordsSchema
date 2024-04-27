using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIndication;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIndication.TreatmentIndication;
public class TreatmentIndication : MedicalIndication
{
    public override string TypeName { get; protected set; } = nameof(TreatmentIndication);
}
