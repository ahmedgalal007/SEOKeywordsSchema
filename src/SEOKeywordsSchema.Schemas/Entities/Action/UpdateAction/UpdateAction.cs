using SEOKeywordsSchema.Schemas.Entities.Actions.InteractActions.CommunicateActions;
using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions;
public class UpdateAction : Action
{
    public override string TypeName { get; protected set; } = nameof(UpdateAction);
}


// TODO AddAction
// TODO DeleteAction
// TODO ReplaceAction