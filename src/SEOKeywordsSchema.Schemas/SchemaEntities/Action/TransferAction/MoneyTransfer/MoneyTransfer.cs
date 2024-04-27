using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TransferActions;
public class MoneyTransfer : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(MoneyTransfer);
}

