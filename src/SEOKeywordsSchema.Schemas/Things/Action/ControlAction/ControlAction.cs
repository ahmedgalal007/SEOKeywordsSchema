using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions;
public class ControlAction : Action
{
    public override string TypeName { get; protected set; } = nameof(ControlAction);
}

