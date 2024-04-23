using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions;
public class InteractAction : Action
{
    public override string TypeName { get; protected set; } = nameof(InteractAction);
}

