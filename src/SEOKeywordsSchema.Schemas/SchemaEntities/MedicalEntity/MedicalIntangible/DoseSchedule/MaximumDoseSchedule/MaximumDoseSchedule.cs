using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.MedicalIntangibles.DoseSchedules;
public class MaximumDoseSchedule : DoseSchedule
{
    public override string TypeName { get; protected set; } = nameof(MaximumDoseSchedule);
}
