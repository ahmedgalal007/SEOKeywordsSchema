using System;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Action.SeekToAction;
public class SeekToAction : Action
{
    public override string TypeName { get; protected set; } = nameof(SeekToAction);
}

