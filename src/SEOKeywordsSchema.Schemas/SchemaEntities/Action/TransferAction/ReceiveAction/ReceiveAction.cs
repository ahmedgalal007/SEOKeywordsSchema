using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TransferActions;
public class ReceiveAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(ReceiveAction);
}

