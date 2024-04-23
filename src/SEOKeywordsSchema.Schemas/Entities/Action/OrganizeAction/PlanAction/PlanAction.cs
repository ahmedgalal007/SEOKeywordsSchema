using SEOKeywordsSchema.Schemas.Entities.Places;
using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.OrganizeActions;
public class PlanAction : OrganizeAction
{
    public override string TypeName { get; protected set; } = nameof(PlanAction);
}

// TODO CancelAction
// TODO ReserveAction
// TODO ScheduleAction