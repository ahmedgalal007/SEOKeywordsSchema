using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TransferActions;
public class LendAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(LendAction);
}

