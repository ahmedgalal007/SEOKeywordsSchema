using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TradeActions;
public class DonateAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(DonateAction);
}

