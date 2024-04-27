using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.DoseSchedule;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.DoseSchedule.MaximumDoseSchedule;
public class MaximumDoseSchedule : DoseSchedule
{
    public override string TypeName { get; protected set; } = nameof(MaximumDoseSchedule);
}
