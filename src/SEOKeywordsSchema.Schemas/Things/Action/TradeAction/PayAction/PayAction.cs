using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TradeActions;
public class PayAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(PayAction);
}

