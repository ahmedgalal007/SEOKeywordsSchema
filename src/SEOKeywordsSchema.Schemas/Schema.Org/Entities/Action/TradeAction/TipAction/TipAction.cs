using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction.TipAction;
public class TipAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(TipAction);
}

