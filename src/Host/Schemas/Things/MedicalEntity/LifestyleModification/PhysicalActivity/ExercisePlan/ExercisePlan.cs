using System;

namespace FSH.WebApi.Domain.Schemas.Things.MedicalEntities.LifestyleModifications.PhysicalActivities;
public class ExercisePlan : PhysicalActivity
{
    public override string TypeName { get; protected set; } = nameof(ExercisePlan);
}
