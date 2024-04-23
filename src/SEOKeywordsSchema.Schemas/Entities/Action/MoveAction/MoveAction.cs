using SEOKeywordsSchema.Schemas.Entities.Actions.MoveActions;
using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions;
public class MoveAction : Action
{
    public override string TypeName { get; protected set; } = nameof(MoveAction);
}


// TODO ArriveAction
// TODO DepartAction
// TODO TravelAction