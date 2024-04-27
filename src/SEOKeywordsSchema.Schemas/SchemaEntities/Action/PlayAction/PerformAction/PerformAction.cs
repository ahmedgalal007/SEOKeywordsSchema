using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.PlayActions;
public class PerformAction : PlayAction
{
    public override string TypeName { get; protected set; } = nameof(PerformAction);
}

