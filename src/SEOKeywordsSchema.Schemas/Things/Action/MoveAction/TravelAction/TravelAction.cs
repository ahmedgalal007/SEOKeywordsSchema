using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.MoveActions;
public class TravelAction : MoveAction
{
    public override string TypeName { get; protected set; } = nameof(TravelAction);
}

