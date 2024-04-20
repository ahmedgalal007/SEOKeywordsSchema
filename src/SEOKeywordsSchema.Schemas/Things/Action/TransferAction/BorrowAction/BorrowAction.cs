using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TransferActions;
public class BorrowAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(BorrowAction);
}

