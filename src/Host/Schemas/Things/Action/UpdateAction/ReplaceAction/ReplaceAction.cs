using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.UpdateActions;
public class ReplaceAction : UpdateAction
{
    public override string TypeName { get; protected set; } = nameof(ReplaceAction);
}

