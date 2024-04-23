using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.TransferActions;
public class DownloadAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(DownloadAction);
}

