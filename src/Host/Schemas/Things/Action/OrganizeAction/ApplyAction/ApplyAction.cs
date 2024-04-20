using FSH.WebApi.Domain.Schemas.Things.Places;
using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.OrganizeActions;
public class ApplyAction : OrganizeAction
{
    public override string TypeName { get; protected set; } = nameof(ApplyAction);
}
