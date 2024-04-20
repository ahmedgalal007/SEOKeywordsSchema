using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions;
public class FindAction : Action
{
    public override string TypeName { get; protected set; } = nameof(FindAction);
}

