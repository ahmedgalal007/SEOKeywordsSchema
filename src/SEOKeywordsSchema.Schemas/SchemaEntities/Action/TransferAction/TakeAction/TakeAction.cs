using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TransferActions;
public class TakeAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(TakeAction);
}

