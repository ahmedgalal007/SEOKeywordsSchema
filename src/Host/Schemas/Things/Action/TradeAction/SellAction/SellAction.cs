﻿using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.TradeActions;
public class SellAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(SellAction);
}
