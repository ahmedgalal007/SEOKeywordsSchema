using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.MoveActions;
public class ArriveAction : MoveAction
{
    public override string TypeName { get; protected set; } = nameof(ArriveAction);
}

