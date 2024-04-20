using FSH.WebApi.Domain.Schemas.Things.Places;
using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.OrganizeActions.PlanActions;
public class CancelAction: PlanAction
{
    public override string TypeName { get; protected set; } = nameof(CancelAction);
}
