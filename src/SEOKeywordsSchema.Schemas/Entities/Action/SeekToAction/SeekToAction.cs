using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions;
public class SeekToAction : Action
{
    public override string TypeName { get; protected set; } = nameof(SeekToAction);
}

