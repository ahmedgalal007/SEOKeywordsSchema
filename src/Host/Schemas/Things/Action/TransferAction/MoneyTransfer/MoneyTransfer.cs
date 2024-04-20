using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.TransferActions;
public class MoneyTransfer : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(MoneyTransfer);
}

