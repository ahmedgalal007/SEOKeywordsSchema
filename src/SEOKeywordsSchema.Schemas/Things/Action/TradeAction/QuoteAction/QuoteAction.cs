using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TradeActions;
public class QuoteAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(QuoteAction);
}

