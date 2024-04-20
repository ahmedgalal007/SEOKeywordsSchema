using SEOKeywordsSchema.Schemas.Things.Places;
using System;
using System.Net;

namespace SEOKeywordsSchema.Schemas.Things.Actions.OrganizeActions.AllocateActions;
public class AssignAction : AllocateAction
{
    public override string TypeName { get; protected set; } = nameof(AssignAction);
}