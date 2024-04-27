using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction.MoneyTransfer;
public class MoneyTransfer : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(MoneyTransfer);
}

