using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TransferActions;
public class BorrowAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(BorrowAction);
}

