using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TradeActions;
public class SellAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(SellAction);
}

