using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction.LendAction;
public class LendAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(LendAction);
}

