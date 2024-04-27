using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction.BuyAction;
public class BuyAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(BuyAction);
}

