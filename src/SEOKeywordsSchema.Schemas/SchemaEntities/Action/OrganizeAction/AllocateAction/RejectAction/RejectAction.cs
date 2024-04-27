using SEOKeywordsSchema.Schemas.SchemaEntities.Places;
using System;
using System.Net;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.OrganizeActions.AllocateActions;
public class RejectAction : AllocateAction
{
    public override string TypeName { get; protected set; } = nameof(RejectAction);
}