using FSH.WebApi.Domain.Schemas.Things.Places;
using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.OrganizeActions.PlanActions;
public class ReserveAction : PlanAction
{
    public override string TypeName { get; protected set; } = nameof(ReserveAction);
}
