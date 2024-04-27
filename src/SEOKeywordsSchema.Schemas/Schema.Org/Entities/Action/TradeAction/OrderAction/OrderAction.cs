﻿using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TradeAction.OrderAction;
public class OrderAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(OrderAction);
}
