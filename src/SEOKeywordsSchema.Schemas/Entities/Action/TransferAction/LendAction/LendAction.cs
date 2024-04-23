using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TransferActions;
public class LendAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(LendAction);
}

