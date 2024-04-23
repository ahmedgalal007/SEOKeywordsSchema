
using System;

namespace SEOKeywordsSchema.Schemas.Entities.MedicalEntities.MedicalIntangibles.DoseSchedules;
public class RecommendedDoseSchedule : DoseSchedule
{
    public override string TypeName { get; protected set; } = nameof(RecommendedDoseSchedule);
}
