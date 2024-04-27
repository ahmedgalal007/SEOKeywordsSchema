using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalIntangibles.DoseSchedules;
public class ReportedDoseSchedule : DoseSchedule
{
    public override string TypeName { get; protected set; } = nameof(ReportedDoseSchedule);
}
