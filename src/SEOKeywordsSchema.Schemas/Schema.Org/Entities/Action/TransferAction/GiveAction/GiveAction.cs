﻿using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction.GiveAction;
public class GiveAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(GiveAction);
}

