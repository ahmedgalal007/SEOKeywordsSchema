using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction.PreOrderAction;
public class PreOrderAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(PreOrderAction);
}

