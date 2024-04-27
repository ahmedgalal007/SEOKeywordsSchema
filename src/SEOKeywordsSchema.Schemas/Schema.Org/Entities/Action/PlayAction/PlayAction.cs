using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.PlayAction;
public class PlayAction : Action
{
    public override string TypeName { get; protected set; } = nameof(PlayAction);
}

// TODO ExerciseAction
// TODO PerformAction