using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.MoveActions;
public class TravelAction : MoveAction
{
    public override string TypeName { get; protected set; } = nameof(TravelAction);
}

