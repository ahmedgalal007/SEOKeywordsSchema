using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.FindAction;
public class FindAction : Action
{
    public override string TypeName { get; protected set; } = nameof(FindAction);
}

