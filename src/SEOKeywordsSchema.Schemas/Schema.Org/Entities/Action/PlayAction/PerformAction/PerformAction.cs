using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.PlayAction;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.PlayAction.PerformAction;
public class PerformAction : PlayAction
{
    public override string TypeName { get; protected set; } = nameof(PerformAction);
}

