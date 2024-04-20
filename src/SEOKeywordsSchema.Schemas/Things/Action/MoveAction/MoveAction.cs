using SEOKeywordsSchema.Schemas.Things.Actions.MoveActions;
using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions;
public class MoveAction : Action
{
    public override string TypeName { get; protected set; } = nameof(MoveAction);
}


// TODO ArriveAction
// TODO DepartAction
// TODO TravelAction