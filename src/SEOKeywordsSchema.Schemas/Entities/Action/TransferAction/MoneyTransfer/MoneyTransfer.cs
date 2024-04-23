using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TransferActions;
public class MoneyTransfer : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(MoneyTransfer);
}

