using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TransferActions;
public class GiveAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(GiveAction);
}

