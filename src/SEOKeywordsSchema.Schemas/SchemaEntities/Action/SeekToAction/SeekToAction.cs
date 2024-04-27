using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions;
public class SeekToAction : Action
{
    public override string TypeName { get; protected set; } = nameof(SeekToAction);
}

