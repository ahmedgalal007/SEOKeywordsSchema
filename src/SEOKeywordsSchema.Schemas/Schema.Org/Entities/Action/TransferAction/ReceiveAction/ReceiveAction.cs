using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction.ReceiveAction;
public class ReceiveAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(ReceiveAction);
}

