using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TradeActions;
public class BuyAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(BuyAction);
}

