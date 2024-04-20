using SEOKeywordsSchema.Schemas.Things.Places;
using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.OrganizeActions.PlanActions;
public class ScheduleAction: PlanAction
{
    public override string TypeName { get; protected set; } = nameof(ScheduleAction);
}
