using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.ControlAction;
public class ControlAction : Action
{
    public override string TypeName { get; protected set; } = nameof(ControlAction);
}

