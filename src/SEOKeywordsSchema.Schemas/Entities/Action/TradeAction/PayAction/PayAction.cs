using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TradeActions;
public class PayAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(PayAction);
}

