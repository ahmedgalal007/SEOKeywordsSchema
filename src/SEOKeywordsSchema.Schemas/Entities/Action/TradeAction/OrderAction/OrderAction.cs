using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TradeActions;
public class OrderAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(OrderAction);
}

