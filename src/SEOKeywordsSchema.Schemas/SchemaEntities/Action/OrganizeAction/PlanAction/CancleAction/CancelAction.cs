using SEOKeywordsSchema.Schemas.SchemaEntities.Places;
using System;

namespace SEOKeywordsSchema.Schemas.SchemaEntities.Actions.OrganizeActions.PlanActions;
public class CancelAction: PlanAction
{
    public override string TypeName { get; protected set; } = nameof(CancelAction);
}
