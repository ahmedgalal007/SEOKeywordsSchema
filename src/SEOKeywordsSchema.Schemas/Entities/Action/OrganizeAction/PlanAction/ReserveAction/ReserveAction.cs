using SEOKeywordsSchema.Schemas.Entities.Places;
using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.OrganizeActions.PlanActions;
public class ReserveAction : PlanAction
{
    public override string TypeName { get; protected set; } = nameof(ReserveAction);
}
