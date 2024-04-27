using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction.BorrowAction;
public class BorrowAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(BorrowAction);
}

