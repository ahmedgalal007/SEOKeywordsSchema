using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.UpdateActions;
public class AddAction : UpdateAction
{
    public override string TypeName { get; protected set; } = nameof(AddAction);
}

