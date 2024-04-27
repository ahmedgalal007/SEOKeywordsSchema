using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.TransferAction.DownloadAction;
public class DownloadAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(DownloadAction);
}

