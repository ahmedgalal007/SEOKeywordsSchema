using SEOKeywordsSchema.Schemas.SchemaEntities.Places;
using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.OrganizeActions;
public class ApplyAction : OrganizeAction
{
    public override string TypeName { get; protected set; } = nameof(ApplyAction);
}
