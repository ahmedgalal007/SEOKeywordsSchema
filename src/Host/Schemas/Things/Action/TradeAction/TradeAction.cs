using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions;
public class TradeAction : Action
{
    public override string TypeName { get; protected set; } = nameof(TradeAction);
}


// TODO BuyAction
// TODO DonateAction
// TODO OrderAction
// TODO PayAction
// TODO PreOrderAction
// TODO QuoteAction
// TODO RentAction
// TODO SellAction
// TODO TipAction