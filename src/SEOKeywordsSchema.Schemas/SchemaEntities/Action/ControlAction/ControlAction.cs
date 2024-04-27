using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions;
public class ControlAction : Action
{
    public override string TypeName { get; protected set; } = nameof(ControlAction);
}

