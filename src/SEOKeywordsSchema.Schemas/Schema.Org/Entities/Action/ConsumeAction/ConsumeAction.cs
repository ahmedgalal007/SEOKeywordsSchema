using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.ConsumeAction;
public class ConsumeAction : Action
{
    public override string TypeName { get; protected set; } = nameof(ConsumeAction);
}

