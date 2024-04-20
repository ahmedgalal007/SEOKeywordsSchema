using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.TradeActions;
public class RentAction : TradeAction
{
    public override string TypeName { get; protected set; } = nameof(RentAction);
}

