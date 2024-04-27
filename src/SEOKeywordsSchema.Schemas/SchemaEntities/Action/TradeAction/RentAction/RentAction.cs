using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TradeActions;
public class RentAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(RentAction);
}

