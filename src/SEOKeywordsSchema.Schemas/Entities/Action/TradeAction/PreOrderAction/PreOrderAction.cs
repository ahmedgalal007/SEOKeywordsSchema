using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TradeActions;
public class PreOrderAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(PreOrderAction);
}

