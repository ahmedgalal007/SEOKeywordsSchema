using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.TransferActions;
public class DownloadAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(DownloadAction);
}

