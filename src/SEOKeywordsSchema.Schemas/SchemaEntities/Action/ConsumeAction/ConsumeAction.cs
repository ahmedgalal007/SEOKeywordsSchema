using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions;
public class ConsumeAction : Action
{
    public override string TypeName { get; protected set; } = nameof(ConsumeAction);
}

