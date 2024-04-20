using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.PlayActions;
public class ExerciseAction : PlayAction
{
    public override string TypeName { get; protected set; } = nameof(ExerciseAction);
}

