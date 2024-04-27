using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction.PayAction;
public class PayAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(PayAction);
}

