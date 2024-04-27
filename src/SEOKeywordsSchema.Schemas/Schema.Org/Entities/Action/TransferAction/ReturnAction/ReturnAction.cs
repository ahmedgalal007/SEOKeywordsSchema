using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction.ReturnAction;
public class ReturnAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(ReturnAction);
}

