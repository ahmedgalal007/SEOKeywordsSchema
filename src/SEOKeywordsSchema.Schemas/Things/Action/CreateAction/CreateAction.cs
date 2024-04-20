using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions;
public class CreateAction : Action
{
    public override string TypeName { get; protected set; } = nameof(CreateAction);
}

