using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.OrganizeAction;
public class OrganizeAction : Action
{
    public override string TypeName { get; protected set; } = nameof(OrganizeAction);
}

// TODO AllocateAction
// TODO ApplyAction
// TODO BookmarkAction
// TODO PlanAction