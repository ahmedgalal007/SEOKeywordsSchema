using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.TransferActions;
public class SendAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(SendAction);
}

