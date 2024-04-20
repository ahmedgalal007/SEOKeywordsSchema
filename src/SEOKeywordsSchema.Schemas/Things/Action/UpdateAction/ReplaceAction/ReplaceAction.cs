using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.UpdateActions;
public class ReplaceAction : UpdateAction
{
    public override string TypeName { get; protected set; } = nameof(ReplaceAction);
}

