using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TradeActions;
public class PayAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(PayAction);
}

