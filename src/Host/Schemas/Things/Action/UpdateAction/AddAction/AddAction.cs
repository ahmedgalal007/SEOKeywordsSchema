﻿using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.UpdateActions;
public class AddAction : UpdateAction
{
    public override string TypeName { get; protected set; } = nameof(AddAction);
}

