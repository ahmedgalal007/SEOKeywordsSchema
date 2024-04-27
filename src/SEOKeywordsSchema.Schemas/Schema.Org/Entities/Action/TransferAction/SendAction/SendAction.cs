using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction.SendAction;
public class SendAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(SendAction);
}

