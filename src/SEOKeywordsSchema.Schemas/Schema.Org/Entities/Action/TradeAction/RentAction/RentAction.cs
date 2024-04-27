using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction.RentAction;
public class RentAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(RentAction);
}

