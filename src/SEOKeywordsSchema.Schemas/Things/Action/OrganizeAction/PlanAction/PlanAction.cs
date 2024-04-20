using SEOKeywordsSchema.Schemas.Things.Places;
using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.OrganizeActions;
public class PlanAction : OrganizeAction
{
    public override string TypeName { get; protected set; } = nameof(PlanAction);
}

// TODO CancelAction
// TODO ReserveAction
// TODO ScheduleAction