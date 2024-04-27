using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.MedicalEntities.LifestyleModifications.PhysicalActivities;
public class ExercisePlan : PhysicalActivity
{
    public override string TypeName { get; protected set; } = nameof(ExercisePlan);
}
