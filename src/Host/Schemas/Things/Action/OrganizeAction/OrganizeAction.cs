﻿using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions;
public class OrganizeAction : Action
{
    public override string TypeName { get; protected set; } = nameof(OrganizeAction);
}

// TODO AllocateAction
// TODO ApplyAction
// TODO BookmarkAction
// TODO PlanAction