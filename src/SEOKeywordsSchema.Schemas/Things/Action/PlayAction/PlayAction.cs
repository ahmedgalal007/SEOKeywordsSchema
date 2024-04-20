using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions;
public class PlayAction : Action
{
    public override string TypeName { get; protected set; } = nameof(PlayAction);
}

// TODO ExerciseAction
// TODO PerformAction