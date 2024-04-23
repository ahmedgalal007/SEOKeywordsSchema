using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TradeActions;
public class QuoteAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(QuoteAction);
}

