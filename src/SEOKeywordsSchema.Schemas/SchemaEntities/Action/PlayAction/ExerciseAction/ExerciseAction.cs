using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.PlayActions;
public class ExerciseAction : PlayAction
{
    public override string TypeName { get; protected set; } = nameof(ExerciseAction);
}

