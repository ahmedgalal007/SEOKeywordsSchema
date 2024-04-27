using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction.DonateAction;
public class DonateAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(DonateAction);
}

