using SEOKeywordsSchema.Schemas.Entities.Places;
using System;

namespace SEOKeywordsSchema.Schemas.Entities.Actions.OrganizeActions;
public class ApplyAction : OrganizeAction
{
    public override string TypeName { get; protected set; } = nameof(ApplyAction);
}
