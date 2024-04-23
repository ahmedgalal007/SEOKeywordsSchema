using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions;
public class SearchAction : Action
{
    public override string TypeName { get; protected set; } = nameof(SearchAction);
}

