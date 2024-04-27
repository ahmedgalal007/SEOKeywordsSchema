using SEOKeywordsSchema.Schemas.SchemaEntities.Places;
using System;
using System.Net;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.OrganizeActions.AllocateActions;
public class AssignAction : AllocateAction
{
    public override string TypeName { get; protected set; } = nameof(AssignAction);
}