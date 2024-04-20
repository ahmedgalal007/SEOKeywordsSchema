using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.TransferActions;
public class ReceiveAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(ReceiveAction);
}

