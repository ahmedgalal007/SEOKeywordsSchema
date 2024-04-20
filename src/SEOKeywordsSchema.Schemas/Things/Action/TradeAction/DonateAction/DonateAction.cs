using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TradeActions;
public class DonateAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(DonateAction);
}

