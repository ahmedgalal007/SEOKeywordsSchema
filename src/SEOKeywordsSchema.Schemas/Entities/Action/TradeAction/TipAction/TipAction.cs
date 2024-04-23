using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TradeActions;
public class TipAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(TipAction);
}

