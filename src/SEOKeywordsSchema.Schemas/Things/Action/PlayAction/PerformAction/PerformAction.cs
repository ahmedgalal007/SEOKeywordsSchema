﻿using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.PlayActions;
public class PerformAction : PlayAction
{
    public override string TypeName { get; protected set; } = nameof(PerformAction);
}
