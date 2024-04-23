using SEOKeywordsSchema.Schemas.Entities.Places;
using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.OrganizeActions.PlanActions;
public class CancelAction: PlanAction
{
    public override string TypeName { get; protected set; } = nameof(CancelAction);
}
