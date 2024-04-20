using SEOKeywordsSchema.Schemas.Things.Actions.InteractActions.CommunicateActions;
using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions;
public class UpdateAction : Action
{
    public override string TypeName { get; protected set; } = nameof(UpdateAction);
}


// TODO AddAction
// TODO DeleteAction
// TODO ReplaceAction