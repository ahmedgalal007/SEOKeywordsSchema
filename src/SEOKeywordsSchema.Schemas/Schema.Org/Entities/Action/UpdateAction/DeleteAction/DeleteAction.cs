using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.UpdateAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.UpdateAction.DeleteAction;
public class DeleteAction : UpdateAction
{
    public override string TypeName { get; protected set; } = nameof(DeleteAction);
}

