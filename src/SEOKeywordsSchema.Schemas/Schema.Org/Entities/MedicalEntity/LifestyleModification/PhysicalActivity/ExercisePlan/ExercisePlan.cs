using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.LifestyleModification.PhysicalActivity;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.MedicalEntities.LifestyleModification.PhysicalActivity.ExercisePlan;
public class ExercisePlan : PhysicalActivity
{
    public override string TypeName { get; protected set; } = nameof(ExercisePlan);
}
