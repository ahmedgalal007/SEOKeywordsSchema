using SEOKeywordsSchema.Schemas.Entities.Actions.AchieveActions;
using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions;
public class TransferAction : Action
{
    public override string TypeName { get; protected set; } = nameof(TransferAction);
}


// TODO BorrowAction
// TODO DownloadAction
// TODO GiveAction
// TODO LendAction
// TODO MoneyTransfer
// TODO ReceiveAction
// TODO ReturnAction
// TODO SendAction
// TODO TakeAction
