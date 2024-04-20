﻿using FSH.WebApi.Domain.Schemas.Things.Places;
using System;
using System.Net;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.OrganizeActions;
public class AllocateAction : OrganizeAction
{
    public override string TypeName { get; protected set; } = nameof(AllocateAction);
}

// TODO AcceptAction
// TODO AssignAction
// TODO AuthorizeAction
// TODO RejectAction