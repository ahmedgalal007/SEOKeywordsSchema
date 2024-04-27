using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.UpdateAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.UpdateAction.AddAction;
public class AddAction : UpdateAction
{
    public override string TypeName { get; protected set; } = nameof(AddAction);
}

