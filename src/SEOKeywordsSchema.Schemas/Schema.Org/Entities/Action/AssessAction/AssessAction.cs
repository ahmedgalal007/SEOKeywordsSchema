using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.AssessAction;
public class AssessAction : Action
{
    public override string TypeName { get; protected set; } = nameof(AssessAction);
}

