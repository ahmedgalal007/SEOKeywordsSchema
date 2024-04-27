using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.MoveActions;
public class ArriveAction : MoveAction
{
    public override string TypeName { get; protected set; } = nameof(ArriveAction);
}

