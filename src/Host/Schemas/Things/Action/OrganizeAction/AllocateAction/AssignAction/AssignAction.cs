﻿using FSH.WebApi.Domain.Schemas.Things.Places;
using System;
using System.Net;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.OrganizeActions.AllocateActions;
public class AssignAction : AllocateAction
{
    public override string TypeName { get; protected set; } = nameof(AssignAction);
}