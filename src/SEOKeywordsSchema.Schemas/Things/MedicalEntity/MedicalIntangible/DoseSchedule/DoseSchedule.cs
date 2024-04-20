using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.MedicalIntangibles;
public class DoseSchedule : MedicalIntangible
{
    public override string TypeName { get; protected set; } = nameof(DoseSchedule);
}
