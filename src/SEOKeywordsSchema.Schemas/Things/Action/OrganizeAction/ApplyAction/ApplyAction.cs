using SEOKeywordsSchema.Schemas.Things.Places;
using System;

namespace SEOKeywordsSchema.Schemas.Things.Actions.OrganizeActions;
public class ApplyAction : OrganizeAction
{
    public override string TypeName { get; protected set; } = nameof(ApplyAction);
}
