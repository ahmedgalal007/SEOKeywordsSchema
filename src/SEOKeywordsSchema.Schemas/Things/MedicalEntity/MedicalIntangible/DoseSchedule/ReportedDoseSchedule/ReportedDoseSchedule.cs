using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.MedicalIntangibles.DoseSchedules;
public class ReportedDoseSchedule : DoseSchedule
{
    public override string TypeName { get; protected set; } = nameof(ReportedDoseSchedule);
}
