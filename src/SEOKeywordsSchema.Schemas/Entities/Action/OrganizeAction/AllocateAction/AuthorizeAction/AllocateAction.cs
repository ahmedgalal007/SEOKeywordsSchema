using SEOKeywordsSchema.Schemas.Entities.Places;
using System;
using System.Net;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.OrganizeActions.AllocateActions;
public class AuthorizeAction : AllocateAction
{
    public override string TypeName { get; protected set; } = nameof(AuthorizeAction);
}
