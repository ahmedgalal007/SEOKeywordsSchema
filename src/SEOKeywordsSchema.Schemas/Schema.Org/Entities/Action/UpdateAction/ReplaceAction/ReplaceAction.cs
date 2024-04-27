using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.UpdateAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.UpdateAction.ReplaceAction;
public class ReplaceAction : UpdateAction
{
    public override string TypeName { get; protected set; } = nameof(ReplaceAction);
}

