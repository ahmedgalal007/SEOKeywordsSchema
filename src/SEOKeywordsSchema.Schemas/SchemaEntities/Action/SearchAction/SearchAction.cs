using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions;
public class SearchAction : Action
{
    public override string TypeName { get; protected set; } = nameof(SearchAction);
}

