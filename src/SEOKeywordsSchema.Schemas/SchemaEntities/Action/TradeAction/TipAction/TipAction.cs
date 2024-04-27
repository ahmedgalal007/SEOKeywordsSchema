using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TradeActions;
public class TipAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(TipAction);
}

