using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions;
public class PlayAction : Action
{
    public override string TypeName { get; protected set; } = nameof(PlayAction);
}

// TODO ExerciseAction
// TODO PerformAction