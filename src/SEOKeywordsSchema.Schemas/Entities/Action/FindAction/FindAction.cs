using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions;
public class FindAction : Action
{
    public override string TypeName { get; protected set; } = nameof(FindAction);
}

