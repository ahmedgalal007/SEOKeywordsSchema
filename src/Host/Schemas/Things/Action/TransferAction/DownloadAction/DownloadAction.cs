using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.TransferActions;
public class DownloadAction : TransferAction
{
    public override string TypeName { get; protected set; } = nameof(DownloadAction);
}

