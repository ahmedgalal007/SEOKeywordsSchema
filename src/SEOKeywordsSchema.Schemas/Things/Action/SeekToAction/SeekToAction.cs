using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions;
public class SeekToAction : Action
{
    public override string TypeName { get; protected set; } = nameof(SeekToAction);
}

