using System;

namespace SEOKeywordsSchema.Schemas.Things.MedicalEntities.LifestyleModifications.PhysicalActivities;
public class ExercisePlan : PhysicalActivity
{
    public override string TypeName { get; protected set; } = nameof(ExercisePlan);
}
