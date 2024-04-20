using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TradeActions;
public class RentAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(RentAction);
}

