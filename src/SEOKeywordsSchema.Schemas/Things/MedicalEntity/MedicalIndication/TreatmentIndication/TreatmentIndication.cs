using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.MedicalIndications;
public class TreatmentIndication : MedicalIndication
{
    public override string TypeName { get; protected set; } = nameof(TreatmentIndication);
}
