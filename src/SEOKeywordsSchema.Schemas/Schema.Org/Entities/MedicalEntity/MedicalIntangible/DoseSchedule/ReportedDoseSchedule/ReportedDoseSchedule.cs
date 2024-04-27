using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.DoseSchedule;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.DoseSchedule.ReportedDoseSchedule;
public class ReportedDoseSchedule : DoseSchedule
{
    public override string TypeName { get; protected set; } = nameof(ReportedDoseSchedule);
}
