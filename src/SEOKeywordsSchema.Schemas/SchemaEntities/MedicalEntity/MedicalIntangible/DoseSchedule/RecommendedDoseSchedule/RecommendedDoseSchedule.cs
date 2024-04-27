
using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalIntangibles.DoseSchedules;
public class RecommendedDoseSchedule : DoseSchedule
{
    public override string TypeName { get; protected set; } = nameof(RecommendedDoseSchedule);
}
