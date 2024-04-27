using SEOKeywordsSchema.Schemas.SchemaEntities.Actions.InteractActions.CommunicateActions;
using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions;
public class UpdateAction : Action
{
    public override string TypeName { get; protected set; } = nameof(UpdateAction);
}


// TODO AddAction
// TODO DeleteAction
// TODO ReplaceAction