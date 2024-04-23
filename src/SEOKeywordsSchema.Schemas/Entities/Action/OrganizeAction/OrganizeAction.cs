using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions;
public class OrganizeAction : Action
{
    public override string TypeName { get; protected set; } = nameof(OrganizeAction);
}

// TODO AllocateAction
// TODO ApplyAction
// TODO BookmarkAction
// TODO PlanAction