using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TradeActions;
public class BuyAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(BuyAction);
}

