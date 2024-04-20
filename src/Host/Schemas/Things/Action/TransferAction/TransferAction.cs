using FSH.WebApi.Domain.Schemas.Things.Actions.AchieveActions;
using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions;
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
