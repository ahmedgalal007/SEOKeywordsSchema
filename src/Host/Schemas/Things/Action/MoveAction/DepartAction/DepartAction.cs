﻿using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.MoveActions;
public class DepartAction : MoveAction
{
    public override string TypeName { get; protected set; } = nameof(DepartAction);
}
