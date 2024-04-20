using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TradeActions;
public class SellAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(SellAction);
}

