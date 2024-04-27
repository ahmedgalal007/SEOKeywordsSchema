using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.SearchAction;
public class SearchAction : Action
{
    public override string TypeName { get; protected set; } = nameof(SearchAction);
}

