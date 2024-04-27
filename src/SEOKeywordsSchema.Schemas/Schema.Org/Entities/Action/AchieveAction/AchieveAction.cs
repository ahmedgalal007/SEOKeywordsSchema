using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.AchieveAction;
public class AchieveAction : Action
{
    public override string TypeName { get; protected set; } = nameof(AchieveAction);
}

