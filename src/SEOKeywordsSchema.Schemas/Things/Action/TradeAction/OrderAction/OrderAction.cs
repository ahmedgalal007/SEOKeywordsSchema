using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TradeActions;
public class OrderAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(OrderAction);
}

