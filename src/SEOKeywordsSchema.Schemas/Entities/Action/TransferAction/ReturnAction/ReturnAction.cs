using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TransferActions;
public class ReturnAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(ReturnAction);
}

