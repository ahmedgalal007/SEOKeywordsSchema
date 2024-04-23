using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TradeActions;
public class DonateAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(DonateAction);
}

