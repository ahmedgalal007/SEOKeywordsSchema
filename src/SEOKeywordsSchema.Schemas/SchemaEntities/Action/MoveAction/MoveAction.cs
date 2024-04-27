using SEOKeywordsSchema.Schemas.SchemaEntities.Actions.MoveActions;
using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions;
public class MoveAction : Action
{
    public override string TypeName { get; protected set; } = nameof(MoveAction);
}


// TODO ArriveAction
// TODO DepartAction
// TODO TravelAction