using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.TransferActions;
public class LendAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(LendAction);
}

