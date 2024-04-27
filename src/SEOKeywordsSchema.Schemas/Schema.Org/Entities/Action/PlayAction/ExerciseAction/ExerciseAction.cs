using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.PlayAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.PlayAction.ExerciseAction;
public class ExerciseAction : PlayAction
{
    public override string TypeName { get; protected set; } = nameof(ExerciseAction);
}

