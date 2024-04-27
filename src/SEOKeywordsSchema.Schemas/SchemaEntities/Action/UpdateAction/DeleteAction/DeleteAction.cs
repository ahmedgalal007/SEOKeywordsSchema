using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.UpdateActions;
public class DeleteAction : UpdateAction
{
    public override string TypeName { get; protected set; } = nameof(DeleteAction);
}

