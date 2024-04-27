using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TradeActions;
public class BuyAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(BuyAction);
}

