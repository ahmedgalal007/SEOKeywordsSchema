using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction.QuoteAction;
public class QuoteAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(QuoteAction);
}

