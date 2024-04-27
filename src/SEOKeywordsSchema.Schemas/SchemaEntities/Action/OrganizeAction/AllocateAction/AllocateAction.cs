using SEOKeywordsSchema.Schemas.SchemaEntities.Places;
using System;
using System.Net;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.OrganizeActions;
public class AllocateAction : OrganizeAction
{
    public override string TypeName { get; protected set; } = nameof(AllocateAction);
}

// TODO AcceptAction
// TODO AssignAction
// TODO AuthorizeAction
// TODO RejectAction