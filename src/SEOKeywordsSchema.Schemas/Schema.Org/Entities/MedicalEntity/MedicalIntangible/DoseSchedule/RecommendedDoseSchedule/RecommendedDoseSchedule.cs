
using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.DoseSchedule;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.MedicalIntangible.DoseSchedule.RecommendedDoseSchedule;
public class RecommendedDoseSchedule : DoseSchedule
{
    public override string TypeName { get; protected set; } = nameof(RecommendedDoseSchedule);
}
