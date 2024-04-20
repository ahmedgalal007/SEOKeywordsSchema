using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions;
public class InteractAction : Action
{
    public override string TypeName { get; protected set; } = nameof(InteractAction);
}

