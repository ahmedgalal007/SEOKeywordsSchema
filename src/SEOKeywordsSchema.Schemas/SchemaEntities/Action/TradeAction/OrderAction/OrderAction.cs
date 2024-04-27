using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TradeActions;
public class OrderAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(OrderAction);
}

