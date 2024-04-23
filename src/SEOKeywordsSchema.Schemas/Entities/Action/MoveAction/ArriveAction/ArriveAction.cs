using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.MoveActions;
public class ArriveAction : MoveAction
{
    public override string TypeName { get; protected set; } = nameof(ArriveAction);
}

