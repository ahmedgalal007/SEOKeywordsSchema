using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.MoveActions;
public class DepartAction : MoveAction
{
    public override string TypeName { get; protected set; } = nameof(DepartAction);
}

