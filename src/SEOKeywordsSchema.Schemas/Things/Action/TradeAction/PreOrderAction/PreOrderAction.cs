using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TradeActions;
public class PreOrderAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(PreOrderAction);
}

