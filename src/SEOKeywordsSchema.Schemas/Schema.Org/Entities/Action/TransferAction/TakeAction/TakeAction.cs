using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction.TakeAction;
public class TakeAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(TakeAction);
}

