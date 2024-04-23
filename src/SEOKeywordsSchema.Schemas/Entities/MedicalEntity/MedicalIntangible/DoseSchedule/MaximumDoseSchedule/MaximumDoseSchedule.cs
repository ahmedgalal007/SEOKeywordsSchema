using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalIntangibles.DoseSchedules;
public class MaximumDoseSchedule : DoseSchedule
{
    public override string TypeName { get; protected set; } = nameof(MaximumDoseSchedule);
}
