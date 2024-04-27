using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.InteractAction;
public class InteractAction : Action
{
    public override string TypeName { get; protected set; } = nameof(InteractAction);
}

