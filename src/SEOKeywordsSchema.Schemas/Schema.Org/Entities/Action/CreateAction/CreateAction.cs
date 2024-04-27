using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.CreateAction;
public class CreateAction : Action
{
    public override string TypeName { get; protected set; } = nameof(CreateAction);
}

