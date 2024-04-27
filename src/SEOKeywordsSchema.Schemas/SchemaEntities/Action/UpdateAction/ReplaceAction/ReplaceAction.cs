using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.UpdateActions;
public class ReplaceAction : UpdateAction
{
    public override string TypeName { get; protected set; } = nameof(ReplaceAction);
}

