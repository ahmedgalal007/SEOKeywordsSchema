using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TradeActions;
public class RentAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(RentAction);
}

