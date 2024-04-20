using FSH.WebApi.Domain.Schemas.Things.Places;
using System;

namespace FSH.WebApi.Domain.Schemas.Things.Actions.OrganizeActions;
public class BookmarkAction : OrganizeAction
{
    public override string TypeName { get; protected set; } = nameof(BookmarkAction);
}
