﻿using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.UpdateActions;
public class DeleteAction : UpdateAction
{
    public override string TypeName { get; protected set; } = nameof(DeleteAction);
}
